using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chordale
{
  public abstract class Visualizable
  {
    public string Name;

    public override string ToString()
    {
      return Name;
    }
  }
}
