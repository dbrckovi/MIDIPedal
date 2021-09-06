using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArduinoPedalBridge
{
  class ArduinoConnection
  {
    SerialPort _connection = new SerialPort();
    private Thread _worker;
    bool _shouldAbort = true;
    bool _pingRequested = false;
    byte? _configByte = null;

    public string Port
    {
      get { return _connection.PortName; }
    }

    public int Baud
    {
      get { return _connection.BaudRate; }
    }

    public bool Connected
    {
      get { return _connection != null && _connection.IsOpen; }
    }

    public event Delegates.VoidDelegate ConnectionDetailsChanged;
    private void OnConnectionDetailsChanged()
    {
      ConnectionDetailsChanged?.Invoke();
    }

    /// <summary>
    /// Thrown on exceptions which caused the thread and connection to drop
    /// </summary>
    public event Delegates.ExceptionDelegate FatalException;
    private void OnFatalException(Exception ex)
    {
      FatalException?.Invoke(ex);
    }

    public event Delegates.ButtonStateDelegate ButtonStateReceived;
    private void OnButtonStateReceived(bool b1, bool b2, bool b3)
    {
      ButtonStateReceived?.Invoke(b1, b2, b3);
    }

    public event Delegates.IntDelegate PotValueChanged;
    private void OnPotValueChanged(int value)
    {
      PotValueChanged?.Invoke(value);
    }

    public void Connect(string port, int baud)
    {
      if (_connection.IsOpen) throw new Exception("Already connected");

      _connection.PortName = port;
      _connection.BaudRate = baud;

      _worker = new Thread(Work);
      _worker.IsBackground = true;
      _worker.Name = "Serial connection thread";
      _shouldAbort = false;
      _worker.Start();
    }

    public void Disconnect()
    {
      _shouldAbort = true;
      if (_worker != null) _worker.Join();
    }

    private void Work()
    {
      try
      {
        _connection.Open();

        OnConnectionDetailsChanged();

        _pingRequested = true; //triggers the Ardiono to send it's status as soon as it's connected

        while (_connection.IsOpen && !_shouldAbort)
        {
          if (_pingRequested)
          {
            _connection.Write(new byte[] { 2 }, 0, 1);
            _pingRequested = false;
          }

          if (_configByte.HasValue)
          {
            _connection.Write(new byte[] { _configByte.Value }, 0, 1);
            _configByte = null;
          }

          while (_connection.BytesToRead > 0)
          {
            byte data = (byte)_connection.ReadByte();

            if ((data & 128) == 0)
            {
              //buttons
              bool button1 = (data & 1) == 1;
              bool button2 = (data & 2) == 2;
              bool button3 = (data & 4) == 4;
              OnButtonStateReceived(button1, button2, button3);
            }
            else
            {
              //pot
              int value = (data & 127);
              OnPotValueChanged(value);
            }
          }
          Thread.Sleep(1);
        }
      }
      catch (Exception ex)
      {
        OnFatalException(ex);
      }
      finally
      {
        _connection.Close();
        _worker = null;
        OnConnectionDetailsChanged();
      }
    }

    /// <summary>
    /// Sends ping signal to the Arduino (if connected)
    /// </summary>
    public void Ping()
    {
      if (Connected) _pingRequested = true;
    }

    public void SendConfig(bool togglable1, bool togglable2, bool togglable3)
    {
      /*
      Config byte starts with 1.
      Bit weight represents whether button with that index is togglable.
      10000TTT
      76543210
      7:   indicates that this is a config byte
      6-3: unused
      2-0: button togglable
       */

      if (Connected)
      {
        int cfg = 128;

        if (togglable1) cfg = cfg | 1;
        if (togglable2) cfg = cfg | 2;
        if (togglable3) cfg = cfg | 4;

        _configByte = (byte)cfg;
      }
    }
  }
}
