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
    private bool _formIsClosing = false;
    VirtualMIDI _midi = null;
    ArduinoConnection _arduino = new ArduinoConnection();

    public Form1()
    {
      InitializeComponent();

      _arduino.FatalException += _connection_FatalException;
      _arduino.ConnectionDetailsChanged += _connection_ConnectionDetailsChanged;
      _arduino.ButtonStateReceived += _connection_ButtonStateReceived;
      _arduino.PotValueChanged += _connection_PotValueChanged;
    }

    private void InitializeConnections()
    {
      if (_arduino.Connected) _arduino.Disconnect();
      if (_midi != null) _midi.shutdown();
      
      _arduino.Connect(Settings.Instance.ComPort, Settings.Instance.BaudRate.Value);
      _midi = new VirtualMIDI(Settings.Instance.MidiDeviceName);

      txtMIDIDeviceName.Text = Settings.Instance.MidiDeviceName;
    }

    private void _connection_PotValueChanged(int value)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(delegate { _connection_PotValueChanged(value); }));
        return;
      }

      pedalValue.Value = (float)value / 127f;

      byte channelByte = 0;
      byte controller = 0;
      byte val = Convert.ToByte(value);

      MidiMessage message = new MidiMessage(MIDIMessageType.ControlChange, (MIDIChannel)channelByte, controller, val);
      if (_midi != null) _midi.sendCommand(message.GetBytes());
    }

    private void _connection_ButtonStateReceived(bool button1, bool button2, bool button3)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(delegate { _connection_ButtonStateReceived(button1, button2, button3); }));
        return;
      }

      StringBuilder sb = new StringBuilder();

      sb.Append(button1 ? "1 " : "0 ");
      sb.Append(button2 ? "1 " : "0 ");
      sb.Append(button3 ? "1 " : "0 ");

      txtArduinoButtons.Text = sb.ToString();
    }

    private void _connection_ConnectionDetailsChanged()
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(_connection_ConnectionDetailsChanged));
        return;
      }

      if (_formIsClosing) return;

      txtArduinoConnectionStatus.Text = _arduino.Connected ? "Connected" : "Disconnected";
      txtArduinoConnectionPort.Text = _arduino.Port.ToString();
      txtArduinoConnectionBaud.Text = _arduino.Baud.ToString();
    }

    private void _connection_FatalException(Exception ex)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(delegate { _connection_FatalException(ex); }));
        return;
      }

      MessageBox.Show(this, ex.Message);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        InitializeConnections();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      try
      {
        if (_arduino.Connected) _arduino.Disconnect();
        if (_midi != null) _midi.shutdown();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      _formIsClosing = true;
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      try
      {
        frmSettings settingsForm = new frmSettings();
        DialogResult result = settingsForm.ShowDialog(this);
        if (result == DialogResult.OK) InitializeConnections();
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message);
      }
    }
  }
}
