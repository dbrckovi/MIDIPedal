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

        while (_connection.IsOpen && !_shouldAbort)
        {
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
  }
}
