/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 11.04.2017
 * Time: 15:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainForm
{
  partial class Form2
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    
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
    	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
    	this.label1 = new System.Windows.Forms.Label();
    	this.textBox1 = new System.Windows.Forms.TextBox();
    	this.textBox2 = new System.Windows.Forms.TextBox();
    	this.button1 = new System.Windows.Forms.Button();
    	this.button2 = new System.Windows.Forms.Button();
    	this.button3 = new System.Windows.Forms.Button();
    	this.textBox7 = new System.Windows.Forms.TextBox();
    	this.pictureBox1 = new System.Windows.Forms.PictureBox();
    	this.pictureBox2 = new System.Windows.Forms.PictureBox();
    	this.pictureBox3 = new System.Windows.Forms.PictureBox();
    	this.pictureBox4 = new System.Windows.Forms.PictureBox();
    	this.checkBox1 = new System.Windows.Forms.CheckBox();
    	this.checkBox2 = new System.Windows.Forms.CheckBox();
    	this.checkBox3 = new System.Windows.Forms.CheckBox();
    	this.checkBox4 = new System.Windows.Forms.CheckBox();
    	this.label2 = new System.Windows.Forms.Label();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
    	this.SuspendLayout();
    	// 
    	// label1
    	// 
    	this.label1.Location = new System.Drawing.Point(12, 9);
    	this.label1.Name = "label1";
    	this.label1.Size = new System.Drawing.Size(28, 17);
    	this.label1.TabIndex = 0;
    	this.label1.Text = "x =";
    	this.label1.Click += new System.EventHandler(this.Label1Click);
    	// 
    	// textBox1
    	// 
    	this.textBox1.Location = new System.Drawing.Point(46, 6);
    	this.textBox1.Name = "textBox1";
    	this.textBox1.Size = new System.Drawing.Size(123, 20);
    	this.textBox1.TabIndex = 1;
    	this.textBox1.Text = "0";
    	// 
    	// textBox2
    	// 
    	this.textBox2.Location = new System.Drawing.Point(46, 32);
    	this.textBox2.Name = "textBox2";
    	this.textBox2.Size = new System.Drawing.Size(123, 20);
    	this.textBox2.TabIndex = 4;
    	this.textBox2.Text = "1";
    	// 
    	// button1
    	// 
    	this.button1.Location = new System.Drawing.Point(12, 58);
    	this.button1.Name = "button1";
    	this.button1.Size = new System.Drawing.Size(157, 23);
    	this.button1.TabIndex = 5;
    	this.button1.Text = "Calculate";
    	this.button1.UseVisualStyleBackColor = true;
    	this.button1.Click += new System.EventHandler(this.Button1Click);
    	// 
    	// button2
    	// 
    	this.button2.Location = new System.Drawing.Point(402, 4);
    	this.button2.Name = "button2";
    	this.button2.Size = new System.Drawing.Size(75, 23);
    	this.button2.TabIndex = 14;
    	this.button2.Text = "Пример 1";
    	this.button2.UseVisualStyleBackColor = true;
    	this.button2.Click += new System.EventHandler(this.Button2Click);
    	// 
    	// button3
    	// 
    	this.button3.Location = new System.Drawing.Point(402, 33);
    	this.button3.Name = "button3";
    	this.button3.Size = new System.Drawing.Size(75, 23);
    	this.button3.TabIndex = 15;
    	this.button3.Text = "Пример 2";
    	this.button3.UseVisualStyleBackColor = true;
    	this.button3.Click += new System.EventHandler(this.Button3Click);
    	// 
    	// textBox7
    	// 
    	this.textBox7.Location = new System.Drawing.Point(12, 278);
    	this.textBox7.Multiline = true;
    	this.textBox7.Name = "textBox7";
    	this.textBox7.ReadOnly = true;
    	this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
    	this.textBox7.Size = new System.Drawing.Size(465, 140);
    	this.textBox7.TabIndex = 16;
    	// 
    	// pictureBox1
    	// 
    	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
    	this.pictureBox1.Location = new System.Drawing.Point(106, 236);
    	this.pictureBox1.Name = "pictureBox1";
    	this.pictureBox1.Size = new System.Drawing.Size(277, 36);
    	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.pictureBox1.TabIndex = 17;
    	this.pictureBox1.TabStop = false;
    	// 
    	// pictureBox2
    	// 
    	this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
    	this.pictureBox2.Location = new System.Drawing.Point(106, 87);
    	this.pictureBox2.Name = "pictureBox2";
    	this.pictureBox2.Size = new System.Drawing.Size(158, 43);
    	this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.pictureBox2.TabIndex = 18;
    	this.pictureBox2.TabStop = false;
    	// 
    	// pictureBox3
    	// 
    	this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
    	this.pictureBox3.Location = new System.Drawing.Point(106, 136);
    	this.pictureBox3.Name = "pictureBox3";
    	this.pictureBox3.Size = new System.Drawing.Size(155, 43);
    	this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.pictureBox3.TabIndex = 19;
    	this.pictureBox3.TabStop = false;
    	// 
    	// pictureBox4
    	// 
    	this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
    	this.pictureBox4.Location = new System.Drawing.Point(106, 185);
    	this.pictureBox4.Name = "pictureBox4";
    	this.pictureBox4.Size = new System.Drawing.Size(112, 43);
    	this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.pictureBox4.TabIndex = 20;
    	this.pictureBox4.TabStop = false;
    	// 
    	// checkBox1
    	// 
    	this.checkBox1.Enabled = false;
    	this.checkBox1.Location = new System.Drawing.Point(12, 96);
    	this.checkBox1.Name = "checkBox1";
    	this.checkBox1.Size = new System.Drawing.Size(88, 24);
    	this.checkBox1.TabIndex = 21;
    	this.checkBox1.UseVisualStyleBackColor = true;
    	// 
    	// checkBox2
    	// 
    	this.checkBox2.Enabled = false;
    	this.checkBox2.Location = new System.Drawing.Point(12, 145);
    	this.checkBox2.Name = "checkBox2";
    	this.checkBox2.Size = new System.Drawing.Size(88, 24);
    	this.checkBox2.TabIndex = 22;
    	this.checkBox2.UseVisualStyleBackColor = true;
    	// 
    	// checkBox3
    	// 
    	this.checkBox3.Enabled = false;
    	this.checkBox3.Location = new System.Drawing.Point(12, 194);
    	this.checkBox3.Name = "checkBox3";
    	this.checkBox3.Size = new System.Drawing.Size(88, 24);
    	this.checkBox3.TabIndex = 23;
    	this.checkBox3.UseVisualStyleBackColor = true;
    	// 
    	// checkBox4
    	// 
    	this.checkBox4.Enabled = false;
    	this.checkBox4.Location = new System.Drawing.Point(12, 243);
    	this.checkBox4.Name = "checkBox4";
    	this.checkBox4.Size = new System.Drawing.Size(88, 24);
    	this.checkBox4.TabIndex = 24;
    	this.checkBox4.UseVisualStyleBackColor = true;
    	// 
    	// label2
    	// 
    	this.label2.Location = new System.Drawing.Point(12, 35);
    	this.label2.Name = "label2";
    	this.label2.Size = new System.Drawing.Size(28, 17);
    	this.label2.TabIndex = 2;
    	this.label2.Text = "y =";
    	this.label2.Click += new System.EventHandler(this.Label2Click);
    	// 
    	// Form2
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(489, 430);
    	this.Controls.Add(this.checkBox4);
    	this.Controls.Add(this.checkBox3);
    	this.Controls.Add(this.checkBox2);
    	this.Controls.Add(this.checkBox1);
    	this.Controls.Add(this.pictureBox4);
    	this.Controls.Add(this.pictureBox3);
    	this.Controls.Add(this.pictureBox2);
    	this.Controls.Add(this.pictureBox1);
    	this.Controls.Add(this.textBox7);
    	this.Controls.Add(this.button3);
    	this.Controls.Add(this.button2);
    	this.Controls.Add(this.button1);
    	this.Controls.Add(this.textBox2);
    	this.Controls.Add(this.label2);
    	this.Controls.Add(this.textBox1);
    	this.Controls.Add(this.label1);
    	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
    	this.MaximizeBox = false;
    	this.MinimizeBox = false;
    	this.Name = "Form2";
    	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    	this.Text = "Task 2.1";
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
    	this.ResumeLayout(false);
    	this.PerformLayout();

    }
  }
}
