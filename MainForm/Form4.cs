/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 23.04.2017
 * Time: 16:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
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
			double y;
			double x = double.Parse(textBox1.Text);
			
			if (x % 5 == 0) {
				y = 100;
				textBox2.Text += "x делится на 5 без остатка\r\n";
			} else {
				y = 500;
				textBox2.Text += "x не делится на 5 без остатка\r\n";
			}
			label2.Text = "y = " + y;
			textBox2.Text += "y = " + y + "\r\n\r\n";
			textBox2.SelectionStart = textBox2.Text.Length;
			textBox2.ScrollToCaret();
		}
	}
}
