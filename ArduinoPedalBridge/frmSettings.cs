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

      BindingList<ButtonEventSetting> eventList = new BindingList<ButtonEventSetting>();
      foreach (ButtonEventSetting item in Settings.Instance.ButtonEvents)
      {
        eventList.Add(item.Copy());
      }
      dataButtonEvents.DataSource = eventList;
    }

    private void AddEvent()
    {
      frmButtonEventSettingEditor editor = new frmButtonEventSettingEditor();
      DialogResult result = editor.ShowDialog(this);
      if (result == DialogResult.OK)
      {
        ((BindingList<ButtonEventSetting>)dataButtonEvents.DataSource).Add(editor.Value);
      }
    }

    private void EditEvent()
    {
      ButtonEventSetting setting = (ButtonEventSetting)dataButtonEvents.SelectedRows[0].DataBoundItem;
      frmButtonEventSettingEditor editor = new frmButtonEventSettingEditor(setting);
      DialogResult result = editor.ShowDialog(this);
      if (result == DialogResult.OK)
      {
        dataButtonEvents.Refresh();
      }
    }

    private void DeleteEvent()
    {
      ButtonEventSetting setting = (ButtonEventSetting)dataButtonEvents.SelectedRows[0].DataBoundItem;
      BindingList<ButtonEventSetting> list = (BindingList<ButtonEventSetting>)dataButtonEvents.DataSource;
      list.Remove(setting);
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

        Settings.Instance.ButtonEvents.Clear();
        foreach (ButtonEventSetting item in (BindingList<ButtonEventSetting>)dataButtonEvents.DataSource)
        {
          Settings.Instance.ButtonEvents.Add(item);
        }

        Settings.Save();
        this.Close();
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

    private void dataButtonEvents_SelectionChanged(object sender, EventArgs e)
    {
      btnEditEvent.Enabled = btnDeleteEvent.Enabled = dataButtonEvents.SelectedRows.Count > 0;
    }

    private void btnAddEvent_Click(object sender, EventArgs e)
    {
      try
      {
        AddEvent();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnEditEvent_Click(object sender, EventArgs e)
    {
      try
      {
        EditEvent();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnDeleteEvent_Click(object sender, EventArgs e)
    {
      try
      {
        DeleteEvent();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void dataButtonEvents_DoubleClick(object sender, EventArgs e)
    {
      if (dataButtonEvents.SelectedRows.Count > 0) EditEvent();
    }

    private void dataButtonEvents_KeyUp(object sender, KeyEventArgs e)
    {
      if (dataButtonEvents.SelectedRows.Count > 0)
      {
        if (e.KeyCode == Keys.Delete) DeleteEvent();
      }
    }
  }
}
