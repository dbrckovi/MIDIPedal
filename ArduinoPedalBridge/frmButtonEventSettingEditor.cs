using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPedalBridge
{
  public partial class frmButtonEventSettingEditor : Form
  {
    private ButtonEventSetting _value = new ButtonEventSetting();

    public ButtonEventSetting Value
    {
      get { return _value; }
    }

    #region Constructors
    public frmButtonEventSettingEditor()
    {
      InitializeComponent();
    }

    public frmButtonEventSettingEditor(ButtonEventSetting value) : this()
    {
      _value = value;
    }

    #endregion Constructors

    private void LoadComboItems()
    {
      cmbButtonIndex.Items.Add(new ComboItem(0, "Button 0"));
      cmbButtonIndex.Items.Add(new ComboItem(1, "Button 1"));
      cmbButtonIndex.Items.Add(new ComboItem(2, "Button 2"));

      cmbButtonEvent.Items.Add(new ComboItem(true, "Pressed"));
      cmbButtonEvent.Items.Add(new ComboItem(false, "Released"));

      cmbMessageType.Items.Add(new ComboItem(MIDIMessageType.NoteOn, "Note ON"));
      cmbMessageType.Items.Add(new ComboItem(MIDIMessageType.NoteOff, "Note OFF"));
    }

    private void LoadSettings()
    {
      foreach (ComboItem item in cmbButtonIndex.Items)
      {
        if ((int)item.Value == _value.ButtonIndex) cmbButtonIndex.SelectedItem = item;
      }

      foreach (ComboItem item in cmbButtonEvent.Items)
      {
        if ((bool)item.Value == _value.ButtonPressed) cmbButtonEvent.SelectedItem = item;
      }


      foreach (ComboItem item in cmbMessageType.Items)
      {
        if ((MIDIMessageType)item.Value == _value.MessageType) cmbMessageType.SelectedItem = item;
      }

      numChannel.Value = _value.Channel;
      numNote.Value = _value.Note;
      numVolume.Value = _value.Volume;
    }

    private void frmButtonEventSettingEditor_Load(object sender, EventArgs e)
    {
      LoadComboItems();
      LoadSettings();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      ComboItem buttonIndexItem = (ComboItem)cmbButtonIndex.SelectedItem;
      ComboItem buttonEventItem = (ComboItem)cmbButtonEvent.SelectedItem;
      ComboItem buttonMessageTypeItem = (ComboItem)cmbMessageType.SelectedItem;

      _value.ButtonIndex = (int)buttonIndexItem.Value;
      _value.ButtonPressed = (bool)buttonEventItem.Value;
      _value.MessageType = (MIDIMessageType)buttonMessageTypeItem.Value;
      _value.Channel = Convert.ToByte(numChannel.Value);
      _value.Note = Convert.ToByte(numNote.Value);
      _value.Volume = Convert.ToByte(numVolume.Value);

      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
