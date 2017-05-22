/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 05.05.2017
 * Time: 22:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form10.
	/// </summary>
	public partial class Form10 : Form
	{
		public Form10()
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
			double fx;
			double zn;
			int a = (int)numericUpDown1.Value;
			int x;
			
			textBox1.Text += "for a = " + a.ToString() + "\r\n";
			for (x = -9; x <= 21; x += 3) {
				textBox1.Text += "when x = " + x.ToString() + "  f(x) = ";
				if ((zn = Math.Sin(Math.PI * x / 6)) != 0) {
					fx = (a * x * x + 3) / zn;
					textBox1.Text += fx.ToString() + "\r\n";
				} else {
					textBox1.Text += "(Error! Divide by zero.)\r\n";
				}
				textBox1.SelectionStart = textBox1.Text.Length;
				textBox1.ScrollToCaret();
			}

			x = -9;
			textBox2.Text += "for a = " + a.ToString() + "\r\n";
			while (x <= 21) {
				textBox2.Text += "when x = " + x.ToString() + "  f(x) = ";
				if ((zn = Math.Sin(Math.PI * x / 6)) != 0) {
					fx = (a * x * x + 3) / zn;
					textBox2.Text += fx.ToString() + "\r\n";
				} else {
					textBox2.Text += "(Error! Divide by zero.)\r\n";
				}
				textBox2.SelectionStart = textBox2.Text.Length;
				textBox2.ScrollToCaret();
				x += 3;
			}

			x=-9;
			textBox3.Text += "for a = " + a.ToString() + "\r\n";
			do {
				textBox3.Text += "when x = " + x.ToString() + "  f(x) = ";
				if ((zn = Math.Sin(Math.PI * x / 6)) != 0) {
					fx = (a * x * x + 3) / zn;
					textBox3.Text += fx.ToString() + "\r\n";
				} else {
					textBox3.Text += "(Error! Divide by zero.)\r\n";
				}
				textBox3.SelectionStart = textBox3.Text.Length;
				textBox3.ScrollToCaret();
				x += 3;
			} while (x <= 21);
		}
	}
}
