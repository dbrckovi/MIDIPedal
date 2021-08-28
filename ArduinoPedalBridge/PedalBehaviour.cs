using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoPedalBridge
{
  //Enumerates pedal
  /// <summary>
  /// Enumerates modes in which pedal values are sent to MIDI device
  /// </summary>
  public enum PedalBehaviour
  {
    /// <summary>
    /// Signals are sent always when they arrive
    /// </summary>
    Always,

    /// <summary>
    /// Signals are sent only when MIDI button is turned on
    /// </summary>
    OnButton
  }
}
