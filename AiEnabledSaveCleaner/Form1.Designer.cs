
namespace AiEnabledSaveCleaner
{
  partial class AiECleaner
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
      this.LblFileInput = new System.Windows.Forms.Label();
      this.TBoxFileInput = new System.Windows.Forms.TextBox();
      this.BtnBrowse = new System.Windows.Forms.Button();
      this.BtnClean = new System.Windows.Forms.Button();
      this.LBoxResult = new System.Windows.Forms.ListBox();
      this.LblResult = new System.Windows.Forms.Label();
      this.LblRemoved = new System.Windows.Forms.Label();
      this.LblInstruction = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // LblFileInput
      // 
      this.LblFileInput.AutoSize = true;
      this.LblFileInput.Location = new System.Drawing.Point(12, 9);
      this.LblFileInput.Name = "LblFileInput";
      this.LblFileInput.Size = new System.Drawing.Size(125, 17);
      this.LblFileInput.TabIndex = 0;
      this.LblFileInput.Text = "World Save Folder";
      // 
      // TBoxFileInput
      // 
      this.TBoxFileInput.Location = new System.Drawing.Point(15, 34);
      this.TBoxFileInput.Name = "TBoxFileInput";
      this.TBoxFileInput.Size = new System.Drawing.Size(647, 22);
      this.TBoxFileInput.TabIndex = 1;
      this.TBoxFileInput.WordWrap = false;
      // 
      // BtnBrowse
      // 
      this.BtnBrowse.Location = new System.Drawing.Point(668, 34);
      this.BtnBrowse.Name = "BtnBrowse";
      this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
      this.BtnBrowse.TabIndex = 2;
      this.BtnBrowse.Text = "Browse...";
      this.BtnBrowse.UseVisualStyleBackColor = true;
      this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
      // 
      // BtnClean
      // 
      this.BtnClean.Location = new System.Drawing.Point(15, 77);
      this.BtnClean.Name = "BtnClean";
      this.BtnClean.Size = new System.Drawing.Size(75, 23);
      this.BtnClean.TabIndex = 3;
      this.BtnClean.Text = "Clean";
      this.BtnClean.UseVisualStyleBackColor = true;
      this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
      // 
      // LBoxResult
      // 
      this.LBoxResult.FormattingEnabled = true;
      this.LBoxResult.ItemHeight = 16;
      this.LBoxResult.Location = new System.Drawing.Point(15, 138);
      this.LBoxResult.Name = "LBoxResult";
      this.LBoxResult.Size = new System.Drawing.Size(224, 292);
      this.LBoxResult.TabIndex = 4;
      // 
      // LblResult
      // 
      this.LblResult.AutoSize = true;
      this.LblResult.Location = new System.Drawing.Point(102, 82);
      this.LblResult.Name = "LblResult";
      this.LblResult.Size = new System.Drawing.Size(0, 17);
      this.LblResult.TabIndex = 5;
      // 
      // LblRemoved
      // 
      this.LblRemoved.AutoSize = true;
      this.LblRemoved.Location = new System.Drawing.Point(15, 115);
      this.LblRemoved.Name = "LblRemoved";
      this.LblRemoved.Size = new System.Drawing.Size(128, 17);
      this.LblRemoved.TabIndex = 6;
      this.LblRemoved.Text = "Identities Removed";
      // 
      // LblInstruction
      // 
      this.LblInstruction.AutoSize = true;
      this.LblInstruction.Location = new System.Drawing.Point(262, 185);
      this.LblInstruction.Name = "LblInstruction";
      this.LblInstruction.Size = new System.Drawing.Size(0, 17);
      this.LblInstruction.TabIndex = 7;
      // 
      // AiECleaner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.LblInstruction);
      this.Controls.Add(this.LblRemoved);
      this.Controls.Add(this.LblResult);
      this.Controls.Add(this.LBoxResult);
      this.Controls.Add(this.BtnClean);
      this.Controls.Add(this.BtnBrowse);
      this.Controls.Add(this.TBoxFileInput);
      this.Controls.Add(this.LblFileInput);
      this.Name = "AiECleaner";
      this.Text = "AiEnabled SBC Cleaner v1.0";
      this.Load += new System.EventHandler(this.AiECleaner_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblFileInput;
    private System.Windows.Forms.TextBox TBoxFileInput;
    private System.Windows.Forms.Button BtnBrowse;
    private System.Windows.Forms.Button BtnClean;
    private System.Windows.Forms.ListBox LBoxResult;
    private System.Windows.Forms.Label LblResult;
    private System.Windows.Forms.Label LblRemoved;
    private System.Windows.Forms.Label LblInstruction;
  }
}

