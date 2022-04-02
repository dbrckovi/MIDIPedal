using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chordale
{
  public class Chord : Visualizable
  {
    /// <summary>
    /// List of string states: 0: open, <1: muted, >0: fret position
    /// </summary>
    public Dictionary<StringName, int> StringState;
    public ChordType ChordType = ChordType.Unknown;

    public Chord(string name, ChordType chordType)
    {
      Name = name;
      ChordType = chordType;

      StringState = new Dictionary<StringName, int>();
      foreach (StringName guitarString in Enum.GetValues(typeof(StringName)))
      {
        StringState.Add(guitarString, -1);
      }
    }

    public Chord(string name, ChordType chordType, int lowE, int a, int d, int g, int b, int highE) : this(name, chordType)
    {
      SetStates(lowE, a, d, g, b, highE);
    }

    public void SetStates(int lowE, int a, int d, int g, int b, int highE)
    {
      StringState[StringName.lowE] = lowE;
      StringState[StringName.A] = a;
      StringState[StringName.D] = d;
      StringState[StringName.G] = g;
      StringState[StringName.B] = b;
      StringState[StringName.highE] = highE;
    }

    public static List<Chord> GetAllChords()
    {
      List<Chord> ret = new List<Chord>();

      //major
      ret.Add(new Chord("C", ChordType.Major, -1, 3, 2, 0, 1, 0));
      ret.Add(new Chord("C#", ChordType.Major, -1, -1, 3, 1, 2, 1));
      ret.Add(new Chord("D", ChordType.Major, -1, -1, 0, 2, 3, 2));
      ret.Add(new Chord("D#", ChordType.Major, -1, -1, 1, 3, 4, 3));
      ret.Add(new Chord("E", ChordType.Major, 0, 2, 2, 1, 0, 0));
      ret.Add(new Chord("F", ChordType.Major, 1, 3, 3, 2, 1, 1));
      ret.Add(new Chord("F#", ChordType.Major, 2, 4, 4, 3, 2, 2));
      ret.Add(new Chord("G", ChordType.Major, 3, 2, 0, 0, 0, 3));
      ret.Add(new Chord("G#", ChordType.Major, 4, 6, 6, 5, 4, 4));
      ret.Add(new Chord("A", ChordType.Major, -1, 0, 2, 2, 2, 0));
      ret.Add(new Chord("A#", ChordType.Major, -1, 1, 3, 3, 3, 1));
      ret.Add(new Chord("B", ChordType.Major, -1, 2, 4, 4, 4, 2));

      //minor
      ret.Add(new Chord("Cm", ChordType.Minor, -1, 3, 5, 5, 4, 3));
      ret.Add(new Chord("C#m", ChordType.Minor, -1, 4, 6, 6, 5, 4));
      ret.Add(new Chord("Dm", ChordType.Minor, -1, -1, 0, 2, 3, 1));
      ret.Add(new Chord("D#m", ChordType.Minor, -1, -1, 4, 3, 4, 2));
      ret.Add(new Chord("Em", ChordType.Minor, 0, 2, 2, 0, 0, 0));
      ret.Add(new Chord("Fm", ChordType.Minor, 1, 3, 3, 1, 1, 1));
      ret.Add(new Chord("F#m", ChordType.Minor, 2, 4, 4, 2, 2, 2));
      ret.Add(new Chord("Gm", ChordType.Minor, 3, 5, 5, 3, 3, 3));
      ret.Add(new Chord("G#m", ChordType.Minor, 4, 6, 6, 4, 4, 4));
      ret.Add(new Chord("Am", ChordType.Minor, -1, 0, 2, 2, 1, 0));
      ret.Add(new Chord("A#m", ChordType.Minor, -1, 1, 3, 3, 2, 1));
      ret.Add(new Chord("Bm", ChordType.Minor, -1, 2, 0, 4, 3, 2));

      //Dominant 7
      ret.Add(new Chord("C7", ChordType.Dominant7, -1, 3, 2, 3, 1, 0));
      ret.Add(new Chord("D7", ChordType.Dominant7, -1, -1, 0, 2, 1, 2));
      ret.Add(new Chord("E7", ChordType.Dominant7, 0, 2, 0, 1, 0, 0));
      ret.Add(new Chord("F7", ChordType.Dominant7, 1, 3, 1, 2, 1, 1));
      ret.Add(new Chord("G7", ChordType.Dominant7, 3, 2, 0, 0, 0, 1));
      ret.Add(new Chord("A7", ChordType.Dominant7, -1, 0, 2, 0, 2, 0));
      ret.Add(new Chord("B7", ChordType.Dominant7, -1, 2, 1, 2, 0, 2));

      return ret;
    }
  }
}
