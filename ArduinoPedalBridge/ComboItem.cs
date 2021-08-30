using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoPedalBridge
{
  public class ComboItem
  {
    public object Value;
    public string Text;

    public ComboItem(object value, string text)
    {
      Value = value;
      Text = text;
    }

    public override string ToString()
    {
      return Text;
    }
  }
}
