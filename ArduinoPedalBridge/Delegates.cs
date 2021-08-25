using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoPedalBridge
{
  public class Delegates
  {
    public delegate void VoidDelegate();
    public delegate void ExceptionDelegate(Exception ex);
    public delegate void ButtonStateDelegate(bool button1, bool button2, bool button3);
    public delegate void IntDelegate(int value);
  }
}
