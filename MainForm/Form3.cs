/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 22.04.2017
 * Time: 17:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			double x = double.Parse(textBox1.Text); // Парсим значение из значения Text элемента textBox1 
			double y = double.Parse(textBox2.Text); //
			double a = double.Parse(textBox3.Text); //
			bool A = (x > Math.Abs(a)) && ((y > 0) || (y < -x));
			bool B = (x < Math.Abs(a) && x > 0) && ((y < 0) && (y > -x));
			bool C = x < 0 && (y > 0 && y < -x);
			checkBox1.Checked = A;
			checkBox2.Checked = B;
			checkBox3.Checked = C;
			
			if (A || B || C) {
				label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				label4.Text = "Точка находится на заштрихованой области";
			} else {
				label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				label4.Text = "Точка находится вне заштрихованой области";
			}
			textBox4.Text += "При x=" + x + ", y=" + y + " и a=" + a + " результат:\r\n" + label4.Text + "\r\n\r\n";
			textBox4.SelectionStart = textBox4.Text.Length;
			textBox4.ScrollToCaret();
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = "-4";
			textBox2.Text = "2";
			textBox3.Text = "5";
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = "3";
			textBox2.Text = "-2";
			textBox3.Text = "5";
		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text = "6";
			textBox2.Text = "2";
			textBox3.Text = "5";
		}
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Text = "6";
			textBox2.Text = "-7";
			textBox3.Text = "5";
		}
	}
}
