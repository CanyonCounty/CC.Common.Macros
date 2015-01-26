using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC.Common.Macro.Demo
{
  class Demo4
  {
    public string Name
    {
      get { return "John Que Public"; }
    }

    public string Hobby
    {
      get { return "Programming"; }
    }

    public DateTime Birthday
    {
      get { return DateTime.Today; }
    }

    public int FavoriteNumber
    {
      get { return 42; }
    }

    public bool IsHappy
    {
      get { return true; }
    }

    [System.ComponentModel.Browsable(false)]
    public string YouCanNotSeeThis
    {
      get { return "Since this is not browsable, you can't see me"; }
    }
  }
}
