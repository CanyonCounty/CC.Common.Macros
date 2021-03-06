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

I've added a Formatter option now. So you can be a delagate for the changes, it's simple to use.

```C#
    private string FormatValue(string property, string value)
    {
      // Now I have a hook into what's being changed.
      string ret = value;
      if (property.Equals("Age")) {
        int age = Int32.Parse(value);
        ret = String.Format("{0:n0}", age);
      }

      return ret;
    }

  // Somewhere else
  Replacer.Formatter = FormatValue;
  demoClass.Age = 4200;
  
  // Age macro is now 4,200

```

Now, if there is an age that's greater than 999 it will be formatted with a digit grouping (a comma in my locale).
