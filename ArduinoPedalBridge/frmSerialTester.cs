using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPedalBridge
{
  public partial class frmSerialTester : Form
  {
    string _portName;
    int _baud;
    SerialPort _port;
    Thread _worker;
    bool _shouldAbort = true;

    #region Constructors
    public frmSerialTester()
    {
      InitializeComponent();
    }

    public frmSerialTester(string portName, int baud) : this()
    {
      _portName = portName;
      _baud = baud;
    }
    #endregion Constructors

    private void ReceiveLoop()
    {
      _port = new SerialPort(_portName, _baud);
      _port.Open();

      while (_port.IsOpen && !_shouldAbort)
      {
        while (_port.BytesToRead > 0)
        {
          int data = _port.ReadByte();
          VisualizeData(data);
        }
        Thread.Sleep(1);
      }
    }

    private void VisualizeData(int data)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new MethodInvoker(() => VisualizeData(data)));
        return;
      }

      txtIncomming.AppendText($"{data.ToString()}{Environment.NewLine}");
      lblLastByte.Text = data.ToString();
      progressLastByte.Value = data;
    }

    private void frmSerialTester_FormClosed(object sender, FormClosedEventArgs e)
    {
      try
      {
        if (_worker != null)
        {
          _shouldAbort = true;
          _worker.Join();
          _worker = null;
        }

        if (_port != null && _port.IsOpen)
        {
          _port.Close();
          _port.Dispose();
          _port = null;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }

    private void frmSerialTester_Load(object sender, EventArgs e)
    {
      try
      {
        _worker = new Thread(ReceiveLoop);
        _worker.IsBackground = true;
        _worker.Name = "Serial read thread";
        _shouldAbort = false;
        _worker.Start();
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message);
      }
    }
  }
}
