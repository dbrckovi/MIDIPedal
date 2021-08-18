using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoPedalBridge
{
  enum MIDIMessageType
  {
    NoteOff = 0x8,
    NoteOn = 0x9,
    PolyphonicKeyPressure = 0xA,
    ControlChange = 0xB,
    ProgramChange = 0xC,
    ChannelPressure = 0xD,
    PitchBend = 0XE
  }
}
