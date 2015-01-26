namespace CC.Common.Macro.Demo
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnReplace = new System.Windows.Forms.Button();
      this.txtText = new System.Windows.Forms.TextBox();
      this.lbMacros = new System.Windows.Forms.ListBox();
      this.cboDemo = new System.Windows.Forms.ComboBox();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnReplace
      // 
      this.btnReplace.Location = new System.Drawing.Point(179, 12);
      this.btnReplace.Name = "btnReplace";
      this.btnReplace.Size = new System.Drawing.Size(75, 23);
      this.btnReplace.TabIndex = 1;
      this.btnReplace.Text = "Replace";
      this.btnReplace.UseVisualStyleBackColor = true;
      this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
      // 
      // txtText
      // 
      this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtText.Location = new System.Drawing.Point(12, 43);
      this.txtText.Multiline = true;
      this.txtText.Name = "txtText";
      this.txtText.Size = new System.Drawing.Size(161, 207);
      this.txtText.TabIndex = 3;
      // 
      // lbMacros
      // 
      this.lbMacros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbMacros.FormattingEnabled = true;
      this.lbMacros.IntegralHeight = false;
      this.lbMacros.Location = new System.Drawing.Point(179, 43);
      this.lbMacros.Name = "lbMacros";
      this.lbMacros.Size = new System.Drawing.Size(185, 207);
      this.lbMacros.TabIndex = 4;
      // 
      // cboDemo
      // 
      this.cboDemo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboDemo.FormattingEnabled = true;
      this.cboDemo.Items.AddRange(new object[] {
            "demo1",
            "demo2",
            "demo3",
            "demo4"});
      this.cboDemo.Location = new System.Drawing.Point(12, 12);
      this.cboDemo.Name = "cboDemo";
      this.cboDemo.Size = new System.Drawing.Size(161, 21);
      this.cboDemo.TabIndex = 0;
      this.cboDemo.SelectedIndexChanged += new System.EventHandler(this.cboDemo_SelectedIndexChanged);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(260, 12);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 23);
      this.btnUpdate.TabIndex = 2;
      this.btnUpdate.Text = "Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(376, 262);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.cboDemo);
      this.Controls.Add(this.lbMacros);
      this.Controls.Add(this.txtText);
      this.Controls.Add(this.btnReplace);
      this.Name = "frmMain";
      this.Text = "CC.Common.Macros Demo";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnReplace;
    private System.Windows.Forms.TextBox txtText;
    private System.Windows.Forms.ListBox lbMacros;
    private System.Windows.Forms.ComboBox cboDemo;
    private System.Windows.Forms.Button btnUpdate;
  }
}

