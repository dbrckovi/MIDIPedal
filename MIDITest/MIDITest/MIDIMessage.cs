using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDITest
{
  class MidiMessage
  {
    //https://users.cs.cf.ac.uk/Dave.Marshall/Multimedia/node158.html

    public MIDIMessageType MessageType = MIDIMessageType.NoteOn;
    public MIDIChannel Channel = MIDIChannel.C1;
    public byte Byte1 = 0;
    public byte? Byte2 = null;

    public MidiMessage(MIDIMessageType messageType, MIDIChannel channel, byte byte1, byte? byte2 = null)
    {
      MessageType = messageType;
      Channel = channel;
      Byte1 = byte1;
      Byte2 = byte2;
    }

    public byte[] GetBytes()
    {
      byte[] ret;
      if (Byte2 != null) ret = new byte[3];
      else ret = new byte[2];

      byte messageBits = (byte)MessageType;
      messageBits = (byte)(messageBits << 4);

      byte channelBits = (byte)Channel;

      ret[0] = (byte)(ret[0] | messageBits);
      ret[0] = (byte)(ret[0] | channelBits);

      ret[1] = Byte1;
      if (Byte2 != null) ret[2] = Byte2.Value;

      return ret;
    }
  }
}
