using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPedalBridge
{
  public partial class Form1 : Form
  {
    ArduinoConnection _connection = new ArduinoConnection();

    public Form1()
    {
      InitializeComponent();
      _connection.ButtonStateChanged += _connection_ButtonStateChanged;
      _connection.PotStateChanged += _connection_PotStateChanged;
    }

    private void _connection_PotStateChanged(int value)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(() => _connection_PotStateChanged(value)));
        return;
      }

      lblPot.Text = value.ToString();
    }

    private void _connection_ButtonStateChanged(int index, bool state)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(() => _connection_ButtonStateChanged(index, state)));
        return;
      }

      if (index == 0) lblButton1.Text = state.ToString();
      else lblButton2.Text = state.ToString();
    }

    private void LoadSettings()
    {
      LoadSerialPorts();
      LoadBaudRates();
    }

    private void LoadSerialPorts()
    {
      cmbSerialPort.Items.Clear();
      foreach (string port in SerialPort.GetPortNames())
      {
        cmbSerialPort.Items.Add(port);

        //TODO: compare with setting and set selected instead of this...
        if (cmbSerialPort.SelectedItem == null) cmbSerialPort.SelectedItem = port;
      }
    }

    private void LoadBaudRates()
    {
      cmbSerialBaud.Items.Clear();
      cmbSerialBaud.Items.Add(300);
      cmbSerialBaud.Items.Add(600);
      cmbSerialBaud.Items.Add(1200);
      cmbSerialBaud.Items.Add(2400);
      cmbSerialBaud.Items.Add(4800);
      cmbSerialBaud.Items.Add(9600);
      cmbSerialBaud.Items.Add(14400);
      cmbSerialBaud.Items.Add(19200);
      cmbSerialBaud.Items.Add(28800);
      cmbSerialBaud.Items.Add(38400);
      cmbSerialBaud.Items.Add(57600);
      cmbSerialBaud.Items.Add(115200);

      //TODO: Load from settings
      cmbSerialBaud.SelectedItem = 57600;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        LoadSettings();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnTestSerial_Click(object sender, EventArgs e)
    {
      try
      {
        if (cmbSerialPort.SelectedItem == null) throw new Exception("Port not selected");
        if (cmbSerialBaud.SelectedItem == null) throw new Exception("Baud not selected");

        string port = (string)cmbSerialPort.SelectedItem;
        int baud = (int)cmbSerialBaud.SelectedItem;

        frmSerialTester tester = new frmSerialTester(port, baud);
        tester.ShowDialog(this);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
      try
      {
        if (cmbSerialPort.SelectedItem == null) throw new Exception("Port not selected");
        if (cmbSerialBaud.SelectedItem == null) throw new Exception("Baud not selected");

        string port = (string)cmbSerialPort.SelectedItem;
        int baud = (int)cmbSerialBaud.SelectedItem;
        _connection.Connect(port, baud);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      _connection.Disconnect();
    }
  }
}
