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

    private void SendButtonEvents(int index, bool newState)
    {
      foreach (ButtonEventSetting setting in Settings.Instance.ButtonEvents)
      {
        if (setting.ButtonIndex == index && setting.ButtonPressed == newState)
        {
          byte channelByte = setting.Channel;
          byte note = setting.Note;
          byte volume = setting.Volume;

          MidiMessage message = new MidiMessage(setting.MessageType, (MIDIChannel)channelByte, note, volume);
          _midi.sendCommand(message.GetBytes());
        }
      }
    }

    private void _connection_PotValueChanged(int value)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(delegate { _connection_PotValueChanged(value); }));
        return;
      }

      try
      {
        pedalValue.Value = (float)value / 127f;

        byte channelByte = 0;
        byte controller = 0;
        byte val = Convert.ToByte(value);

        MidiMessage message = new MidiMessage(MIDIMessageType.ControlChange, (MIDIChannel)channelByte, controller, val);
        if (_midi != null) _midi.sendCommand(message.GetBytes());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        this.Close();
      }
    }

    private void _connection_ButtonStateReceived(bool button1, bool button2, bool button3)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(delegate { _connection_ButtonStateReceived(button1, button2, button3); }));
        return;
      }

      buttonState1.On = button1;
      buttonState2.On = button2;
      buttonState3.On = button3;
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

      if (_arduino.Connected) _arduino.SendConfig(Settings.Instance.ButtonTogglable[0], Settings.Instance.ButtonTogglable[1], Settings.Instance.ButtonTogglable[2]);
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

    private void btnArduinoPing_Click(object sender, EventArgs e)
    {
      _arduino.Ping();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      _arduino.SendConfig(false, false, false);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      _arduino.SendConfig(true, true, true);
    }

    private void button_OnStateChanged(int buttonIndex, bool value)
    {
      try
      {
        SendButtonEvents(buttonIndex, value);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        this.Close();
      }
    }
  }
}
