using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDITest
{
  public partial class Form1 : Form
  {
    VirtualMIDI midi = null;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        midi = new VirtualMIDI("Brc MIDI port");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void SendController()
    {
      byte channelByte = Convert.ToByte(numControllerChannel.Value - 1);
      byte controller = Convert.ToByte(numController.Value);
      byte value = Convert.ToByte(trackControllerValue.Value);

      MidiMessage message = new MidiMessage(MIDIMessageType.ControlChange, (MIDIChannel)channelByte, controller, value);
      LogMessage(message);
      midi.sendCommand(message.GetBytes());
    }

    private void SendNote(bool on)
    {
      MIDIMessageType messageType = on ? MIDIMessageType.NoteOn : MIDIMessageType.NoteOff;
      byte channelByte = Convert.ToByte(numChannel.Value - 1);
      byte note = Convert.ToByte(numNote.Value);
      byte volume = Convert.ToByte(trackVolume.Value);

      MidiMessage message = new MidiMessage(messageType, (MIDIChannel)channelByte, note, volume);
      LogMessage(message);
      midi.sendCommand(message.GetBytes());
    }

    private void LogMessage(MidiMessage message)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Msg: {message.MessageType}, Ch: {message.Channel}, B1: {message.Byte1}, B2: {message.Byte2}");

      byte[] bytes = message.GetBytes();
      List<string> decimalBytes = new List<string>();
      List<string> binaryBytes = new List<string>();

      foreach (byte b in bytes)
      {
        decimalBytes.Add(b.ToString());
        binaryBytes.Add(Convert.ToString(b, 2));
      }

      sb.AppendLine("Dec: " + string.Join(",", decimalBytes.ToArray()));
      sb.AppendLine("Hex: " + BitConverter.ToString(bytes));
      sb.AppendLine("Bin: " + string.Join(",", binaryBytes.ToArray()));

      LogText(sb.ToString());
    }

    private void LogText(string text)
    {
      txtLog.AppendText(text + Environment.NewLine);
    }

    private string ByteToBitString(byte b)
    {
      BitArray array = new BitArray(b);
      return "";

    }

    private void btnON_Click(object sender, EventArgs e)
    {
      try
      {
        SendNote(true);
      }
      catch (Exception ex)
      {
        LogText(ex.Message);
        MessageBox.Show(ex.Message);
      }
    }

    private void btnOFF_Click(object sender, EventArgs e)
    {
      try
      {
        SendNote(false);
      }
      catch (Exception ex)
      {
        LogText(ex.Message);
        MessageBox.Show(ex.Message);
      }
    }

    private void lnkClearLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      txtLog.Text = "";
    }

    private void numControllerValue_Scroll(object sender, EventArgs e)
    {
      SendController();
    }
  }
}
