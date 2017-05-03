/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 29.04.2017
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
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
			double T;
			double t1 = double.Parse(textBox1.Text);
			double t2 = double.Parse(textBox2.Text);
			double t3 = double.Parse(textBox3.Text);
			
			if ((t1 == t2) || (t1 == t3)) {
				T = t1;
			} else {
				if (t2 == t3) {
					T = t2;
				} else {
					T = (t1 + t2 + t3) / 3;
				}
			}
			label4.Text = "T = " + T.ToString();
			
			textBox4.Text += "При t1=" + t1 + ", t2=" + t2 + " и t3=" + t3 + " результат:\r\n" + label4.Text + "\r\n\r\n";
			textBox4.SelectionStart = textBox4.Text.Length;
			textBox4.ScrollToCaret();
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = "2";
			textBox2.Text = "4";
			textBox3.Text = "6";
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = "5";
			textBox2.Text = "5";
			textBox3.Text = "12";
		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text = "2";
			textBox2.Text = "60";
			textBox3.Text = "60";
		}
		void Button5Click(object sender, EventArgs e)
		{
		}
	}
}
