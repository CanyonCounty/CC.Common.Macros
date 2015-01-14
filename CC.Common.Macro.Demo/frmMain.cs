using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CC.Common.Macros;

namespace CC.Common.Macro.Demo
{
  public partial class frmMain : Form
  {
    private object demoClass;
    private string replaceText;

    public frmMain()
    {
      InitializeComponent();
    }

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

    private void LoadDemo1()
    {
      Replacer.Formatter = FormatValue;

      demoClass = new Demo1();
      lbMacros.Items.Clear();
      // These are the default, and you don't need to set them, unless you change them, like I did below.
      Replacer.MacroPrefix = "{";
      Replacer.MacroPostfix = "}";
      lbMacros.Items.AddRange(Replacer.MacroNames(demoClass).ToArray());
      txtText.Text = @"This is a test.

Test = {Test}
Something = {Something}

Nothing else to see here folks.";
      replaceText = txtText.Text;
    }

    private void LoadDemo2()
    {
      demoClass = new Demo2();
      lbMacros.Items.Clear();
      Replacer.MacroPrefix = "%";
      Replacer.MacroPostfix = "%";
      lbMacros.Items.AddRange(Replacer.MacroNames(demoClass).ToArray());
      txtText.Text = @"This is another test.

The current values are
Name = %Name%
Age = %Age%

Click the update button to change the values, then click Replace.
";
      replaceText = txtText.Text;
    }

    private void LoadDemo3()
    {
      demoClass = new Demo2();
      lbMacros.Items.Clear();
      Replacer.MacroPrefix = "$";
      Replacer.MacroPostfix = "";
      lbMacros.Items.AddRange(Replacer.MacroNames(demoClass).ToArray());
      txtText.Text = @"This is another test. Same object as demo2, just different macro style.

Look, I want to be PHP!

The current values are
Name = $Name
Age = $Age

Click the update button to change the values, then click Replace.
";
      replaceText = txtText.Text;
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      cboDemo.SelectedIndex = 0;
    }
    
    private void cboDemo_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (cboDemo.SelectedIndex)
      {
        case 0: LoadDemo1(); break;
        case 1: LoadDemo2(); break;
        case 2: LoadDemo3(); break;
      }
    }

    private void btnReplace_Click(object sender, EventArgs e)
    {
      txtText.Text = Replacer.Replace(replaceText, demoClass);
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (demoClass is Demo2)
      {
        Demo2 demo = (Demo2)demoClass;
        demo.Name = "Yosemite Sam";
        demo.Age = 42;
        demoClass = demo;
      }
      else
      {
        MessageBox.Show("Current demo not supported");
      }
    }

  }
}
