using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CC.Common.Macro.Demo
{
  class Demo2
  {
    private string _name = "Unknown";
    private int _age = 24;

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public int Age
    {
      get { return _age; }
      set { _age = value; }
    }

    [Browsable(false)]
    public string AppSpecific
    {
      get { return "I don't want macro's seeing me!"; }
    }

    private string Private
    {
      get { return "Private"; }
    }

    protected string Protected
    {
      get { return "Protected"; }
    }

    internal string Internal
    {
      get { return "Internal"; }
    }
  }
}
