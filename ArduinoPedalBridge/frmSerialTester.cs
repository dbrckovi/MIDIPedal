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
    DateTime _startTime = DateTime.Now;

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
      _port.Close();
    }

    private void VisualizeData(int data)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(() => VisualizeData(data)));
        return;
      }

      //txtIncomming.AppendText($"{data.ToString()} - {ByteToBitString(data)}{Environment.NewLine}");
      lblLastByte.Text = $"{data.ToString()} - {ByteToBitString(data)}";
      progressLastByte.Value = data;
    }

    private string ByteToBitString(int data)
    {
      char[] characters = new char[8];

      for (int x = 0; x <= 7; x++)
      {
        if ((data & Convert.ToInt32(Math.Pow(2, x))) > 0)
        {
          characters[7 - x] = '1';
        }
        else
        {
          characters[7 - x] = '0';
        }
      }
      return new string(characters);
    }

    private void frmSerialTester_FormClosed(object sender, FormClosedEventArgs e)
    {
      try
      {
        timer1.Enabled = false;

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

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtIncomming.Text = "";
    }

    private void frmSerialTester_Shown(object sender, EventArgs e)
    {
      _startTime = DateTime.Now;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      TimeSpan span = DateTime.Now - _startTime;
      lblTime.Text = span.TotalSeconds.ToString();
    }
  }
}
