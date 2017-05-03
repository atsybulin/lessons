/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 07.04.2017
 * Time: 0:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainForm
{
  partial class Form1
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox5;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
    	this.label1 = new System.Windows.Forms.Label();
    	this.label2 = new System.Windows.Forms.Label();
    	this.label3 = new System.Windows.Forms.Label();
    	this.textBox1 = new System.Windows.Forms.TextBox();
    	this.textBox2 = new System.Windows.Forms.TextBox();
    	this.textBox3 = new System.Windows.Forms.TextBox();
    	this.button1 = new System.Windows.Forms.Button();
    	this.textBox4 = new System.Windows.Forms.TextBox();
    	this.label4 = new System.Windows.Forms.Label();
    	this.label5 = new System.Windows.Forms.Label();
    	this.textBox5 = new System.Windows.Forms.TextBox();
    	this.SuspendLayout();
    	// 
    	// label1
    	// 
    	this.label1.Location = new System.Drawing.Point(12, 9);
    	this.label1.Name = "label1";
    	this.label1.Size = new System.Drawing.Size(30, 23);
    	this.label1.TabIndex = 0;
    	this.label1.Text = "A =";
    	this.label1.Click += new System.EventHandler(this.Label1Click);
    	// 
    	// label2
    	// 
    	this.label2.Location = new System.Drawing.Point(12, 32);
    	this.label2.Name = "label2";
    	this.label2.Size = new System.Drawing.Size(30, 23);
    	this.label2.TabIndex = 1;
    	this.label2.Text = "B =";
    	// 
    	// label3
    	// 
    	this.label3.Location = new System.Drawing.Point(12, 55);
    	this.label3.Name = "label3";
    	this.label3.Size = new System.Drawing.Size(30, 23);
    	this.label3.TabIndex = 2;
    	this.label3.Text = "C =";
    	// 
    	// textBox1
    	// 
    	this.textBox1.Location = new System.Drawing.Point(48, 6);
    	this.textBox1.Name = "textBox1";
    	this.textBox1.Size = new System.Drawing.Size(100, 20);
    	this.textBox1.TabIndex = 3;
    	this.textBox1.Text = "0";
    	// 
    	// textBox2
    	// 
    	this.textBox2.Location = new System.Drawing.Point(48, 29);
    	this.textBox2.Name = "textBox2";
    	this.textBox2.Size = new System.Drawing.Size(100, 20);
    	this.textBox2.TabIndex = 4;
    	this.textBox2.Text = "0";
    	// 
    	// textBox3
    	// 
    	this.textBox3.Location = new System.Drawing.Point(48, 52);
    	this.textBox3.Name = "textBox3";
    	this.textBox3.Size = new System.Drawing.Size(100, 20);
    	this.textBox3.TabIndex = 5;
    	this.textBox3.Text = "0";
    	// 
    	// button1
    	// 
    	this.button1.Location = new System.Drawing.Point(12, 78);
    	this.button1.Name = "button1";
    	this.button1.Size = new System.Drawing.Size(136, 23);
    	this.button1.TabIndex = 6;
    	this.button1.Text = "Calculate";
    	this.button1.UseVisualStyleBackColor = true;
    	this.button1.Click += new System.EventHandler(this.Button1Click);
    	// 
    	// textBox4
    	// 
    	this.textBox4.Enabled = false;
    	this.textBox4.Location = new System.Drawing.Point(48, 107);
    	this.textBox4.Name = "textBox4";
    	this.textBox4.Size = new System.Drawing.Size(100, 20);
    	this.textBox4.TabIndex = 7;
    	// 
    	// label4
    	// 
    	this.label4.Location = new System.Drawing.Point(12, 110);
    	this.label4.Name = "label4";
    	this.label4.Size = new System.Drawing.Size(30, 23);
    	this.label4.TabIndex = 8;
    	this.label4.Text = "Z =";
    	// 
    	// label5
    	// 
    	this.label5.Location = new System.Drawing.Point(12, 133);
    	this.label5.Name = "label5";
    	this.label5.Size = new System.Drawing.Size(30, 23);
    	this.label5.TabIndex = 9;
    	this.label5.Text = "S =";
    	// 
    	// textBox5
    	// 
    	this.textBox5.Enabled = false;
    	this.textBox5.Location = new System.Drawing.Point(48, 130);
    	this.textBox5.Name = "textBox5";
    	this.textBox5.Size = new System.Drawing.Size(100, 20);
    	this.textBox5.TabIndex = 10;
    	// 
    	// Form1
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(161, 170);
    	this.Controls.Add(this.textBox5);
    	this.Controls.Add(this.label5);
    	this.Controls.Add(this.label4);
    	this.Controls.Add(this.textBox4);
    	this.Controls.Add(this.button1);
    	this.Controls.Add(this.textBox3);
    	this.Controls.Add(this.textBox2);
    	this.Controls.Add(this.textBox1);
    	this.Controls.Add(this.label3);
    	this.Controls.Add(this.label2);
    	this.Controls.Add(this.label1);
    	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
    	this.MaximizeBox = false;
    	this.MinimizeBox = false;
    	this.Name = "Form1";
    	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    	this.Text = "Task 1.1";
    	this.ResumeLayout(false);
    	this.PerformLayout();

    }
  }
}
