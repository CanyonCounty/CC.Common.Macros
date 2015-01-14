# CC.Common.Macros
Simple Project that shows variable substitution

Given an object like so

```C#
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
```

And text like so

```
This is another test.

The current values are
Name = %Name%
Age = %Age%
```

You call a method like so

```C#
string text = Replacer.Replace(replaceText, demoClass);
```

And have output like so

```
This is another test.

The current values are
Name = Unknown
Age = 24
```

Replacer allows you to set prefix and postfix values. They default to { and }

```C#
// These are the default
Replacer.MacroPrefix = "{";
Replacer.MacroPostfix = "}";

// Windows Shell style
Replacer.MacroPrefix = "%";
Replacer.MacroPostfix = "%";
      
// PHP Style
Replacer.MacroPrefix = "$";
Replacer.MacroPostfix = "";
```

It currently only uses public properties. If however, you need a property to be public for application purposes, but don't want Macro substitution you can set the

```C#
[Browsable(false)] // in System.ComponentModel
```

And it will also be hidden from being used as a Macro.

I was thinking about using something else, but I don't want to force a dependancy on this assembly.