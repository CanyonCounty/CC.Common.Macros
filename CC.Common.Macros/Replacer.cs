using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace CC.Common.Macros
{
  public class Replacer
  {
    public static string MacroPrefix = "{";
    public static string MacroPostfix = "}";

    protected static bool MacroProperty(PropertyInfo prop)
    {
      bool ret = true;
      object[] attrs = prop.GetCustomAttributes(true);
      foreach (Attribute attr in attrs)
      {
        if (attr is BrowsableAttribute)
        {
          ret = ((BrowsableAttribute)attr).Browsable == true;
        }
      }
      return ret;
    }

    public static List<string> MacroNames(object objValues)
    {
      List<string> ret = new List<string>();
      PropertyInfo[] props = objValues.GetType().GetProperties();
      foreach (PropertyInfo prop in props)
      {
        if (MacroProperty(prop))
          ret.Add(MacroPrefix + prop.Name + MacroPostfix);
      }

      return ret;
    }

    public static string Replace(string text, object objValues)
    {
      string ret = text;
      PropertyInfo[] props = objValues.GetType().GetProperties();
      foreach (PropertyInfo prop in props)
      {
        string value = prop.GetValue(objValues, null).ToString();
        if (MacroProperty(prop))
          ret = ret.Replace(MacroPrefix + prop.Name + MacroPostfix, value);
      }
      return ret;
    }
  }
}
