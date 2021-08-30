using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoPedalBridge
{
  public class ButtonEventSetting
  {
    /// <summary>
    /// Button index
    /// </summary>
    public int ButtonIndex { get; set; } = 0;
    /// <summary>
    /// Button event (true = pressed, false = released)
    /// </summary>
    public bool ButtonPressed { get; set; } = true;
    /// <summary>
    /// MIDI channel where message will be sent
    /// </summary>
    public byte Channel { get; set; } = 0;
    /// <summary>
    /// MIDI message type
    /// </summary>
    public MIDIMessageType MessageType { get; set; } = MIDIMessageType.NoteOn;
    /// <summary>
    /// MIDI note
    /// </summary>
    public byte Note { get; set; } = 0;
    /// <summary>
    /// Volume of MIDI note
    /// </summary>
    public byte Volume { get; set; } = 0;

    public ButtonEventSetting Copy()
    {
      return JsonConvert.DeserializeObject<ButtonEventSetting>(JsonConvert.SerializeObject(this));
    }
  }
}
