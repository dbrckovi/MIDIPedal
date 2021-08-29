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
  public partial class frmSettings : Form
  {
    public frmSettings()
    {
      InitializeComponent();
    }

    private void LoadSerialPorts()
    {
      string previous = null;
      if (cmbSerialPort.SelectedItem != null) previous = (string)cmbSerialPort.SelectedItem;

      cmbSerialPort.Items.Clear();
      foreach (string port in SerialPort.GetPortNames())
      {
        cmbSerialPort.Items.Add(port);
      }

      if (!string.IsNullOrEmpty(previous) && cmbSerialPort.Items.Contains(previous)) cmbSerialPort.SelectedItem = previous;
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
    }

    private void LoadSettings()
    {
      if (!string.IsNullOrEmpty(Settings.Instance.ComPort) && cmbSerialPort.Items.Contains(Settings.Instance.ComPort))
      {
        cmbSerialPort.SelectedItem = Settings.Instance.ComPort;
      }
      else cmbSerialPort.SelectedItem = null;

      if (Settings.Instance.BaudRate.HasValue && cmbSerialBaud.Items.Contains(Settings.Instance.BaudRate.Value))
      {
        cmbSerialBaud.SelectedItem = Settings.Instance.BaudRate.Value;
      }
      else cmbSerialBaud.SelectedItem = null;

      txtMidiDeviceName.Text = Settings.Instance.MidiDeviceName;
    }

    private void frmSettings_Load(object sender, EventArgs e)
    {
      try
      {
        LoadSerialPorts();
        LoadBaudRates();
        LoadSettings();
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message);
      }
    }

    private void lnkRefreshComPorts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        LoadSerialPorts();
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message);
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        Settings.Instance.ComPort = (string)cmbSerialPort.SelectedItem;
        Settings.Instance.BaudRate = (int?)cmbSerialBaud.SelectedItem;
        Settings.Instance.MidiDeviceName = txtMidiDeviceName.Text;
        
        Settings.Save();
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message);
      }
    }

    private void lnkShowSettingsInFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        string argument = $"/select,\"{Settings.SETTINGS_PATH}\"";
        System.Diagnostics.Process.Start("explorer.exe", argument);
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message);
      }
    }
  }
}
