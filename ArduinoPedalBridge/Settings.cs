using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoPedalBridge
{
  public class Settings
  {
    private string _path = null;

    public string Path
    {
      get { return _path; }
    }

    //Ardiono
    public string ComPort { get; set; }
    public int BaudRate { get; set; }
    public bool[] ButtonTogglable { get; set; } = new bool[3];

    //MIDI
    public string MidiDeviceName { get; set; }
    public PedalBehaviour PedalBehaviour { get; set; }
    public int MIDIButton { get; set; }
  }
}
