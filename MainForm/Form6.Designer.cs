/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 30.04.2017
 * Time: 0:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainForm
{
	partial class Form6
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox textBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(235, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "a[1] = 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(106, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "a[2] = 4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(164, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "a[3] = 1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Enter n elements: ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(235, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(118, 81);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			35,
			0,
			0,
			0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
			4,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(129, 20);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.Value = new decimal(new int[] {
			4,
			0,
			0,
			0});
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 138);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(235, 160);
			this.textBox1.TabIndex = 8;
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 310);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form6";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task 3.1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
