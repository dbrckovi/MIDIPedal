using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArduinoPedalBridge
{
  public class Settings
  {
    public static readonly string SETTINGS_PATH = Path.Combine(Program.ProgramDataPath, "settings.ini");

    private static Settings _instance = null;

    public static Settings Instance
    {
      get
      {
        if (_instance == null) Load();
        return _instance;
      }
    }

    //Ardiono
    public string ComPort { get; set; }
    public int? BaudRate { get; set; }
    public bool[] ButtonTogglable { get; set; } = new bool[3];

    //MIDI
    public string MidiDeviceName { get; set; }
    public PedalBehaviour PedalBehaviour { get; set; }
    public int MIDIButton { get; set; }

    public static void Load()
    {
      if (!File.Exists(SETTINGS_PATH)) Save();
      else
      {
        string serialized = File.ReadAllText(SETTINGS_PATH);
        _instance = JsonConvert.DeserializeObject<Settings>(serialized);
      }
    }

    public static void Save()
    {
      if (_instance == null) _instance = new Settings();

      string serialized = JsonConvert.SerializeObject(_instance, Formatting.Indented);
      File.WriteAllText(SETTINGS_PATH, serialized);
    }
  }
}
