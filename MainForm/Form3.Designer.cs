/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 22.04.2017
 * Time: 17:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainForm
{
	partial class Form3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "x =";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(46, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "y =";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "a =";
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
			this.button1.Location = new System.Drawing.Point(12, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(46, 58);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(123, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(324, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Sample 1";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(324, 41);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "Sample 2";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(324, 70);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(103, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "Sample 3";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(306, 26);
			this.label4.TabIndex = 11;
			this.label4.Text = "результат";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(324, 99);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(103, 23);
			this.button5.TabIndex = 12;
			this.button5.Text = "Sample 4";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new System.Drawing.Point(175, 4);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(143, 24);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "область больше |a|";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Enabled = false;
			this.checkBox2.Location = new System.Drawing.Point(175, 30);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(143, 24);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "область между 0 и |a|";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Enabled = false;
			this.checkBox3.Location = new System.Drawing.Point(175, 56);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(143, 24);
			this.checkBox3.TabIndex = 15;
			this.checkBox3.Text = "область меньше 0";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 150);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox4.Size = new System.Drawing.Size(415, 165);
			this.textBox4.TabIndex = 16;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(433, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(285, 303);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 327);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task 2.2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
