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
    private string _port;
    private int _baud;
    SerialPort _connection;
    private Thread _worker;
    bool _shouldAbort = true;

    public string Port
    {
      get { return _port; }
    }

    public int Baud
    {
      get { return _baud; }
    }

    public delegate void ButtonStateDelegate(int index, bool state);
    public delegate void PotStateDelegate(int value);

    public event ButtonStateDelegate ButtonStateChanged;
    public event PotStateDelegate PotStateChanged;

    private void OnButtonStateChanged(int index, bool state)
    {
      ButtonStateChanged?.Invoke(index, state);
    }

    private void OnPotStateChanged(int value)
    {
      PotStateChanged?.Invoke(value);
    }

    public void Connect(string port, int baud)
    {
      if (_worker != null || _connection != null) throw new Exception("Already connected");

      _port = port;
      _baud = baud;

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
      _worker = null;
      _connection = null;
    }

    private void Work()
    {
      /*
       BUTTON BYTE
        76543210
        0IIIIIIS
       
        0 - indicates a button
        I - button index
        S - button state

        POT BYTE
        76543210
        1VVVVVVV

        1 - indicates a pot
        V - pot value
       */

      _connection = new SerialPort(_port, _baud);
      _connection.Open();

      while (_connection.IsOpen && !_shouldAbort)
      {
        while (_connection.BytesToRead > 0)
        {
          byte data = (byte)_connection.ReadByte();

          if ((data & 128) == 0)
          {
            //button
            int index = (data & 126) >> 1;
            bool state = (data & 1) == 1;
            OnButtonStateChanged(index, state);
          }
          else
          {
            //pot
            int value = (data & 127);
            OnPotStateChanged(value);
          }
        }
        Thread.Sleep(1);
      }

      _connection.Close();
      _connection.Dispose();
      _connection = null;
      _worker = null;
    }
  }
}
