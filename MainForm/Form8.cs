/*
 * Created by SharpDevelop.
 * User: tsybulin
 * Date: 03.05.2017
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form8.
	/// </summary>
	public partial class Form8 : Form
	{
		static double factorial(double x)
		{
			return x <= 1 ? 1 : x * factorial(x - 1);
		}
		
		public Form8()
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
			int n = (int)numericUpDown1.Value;
			double m = factorial(n);
			int c = 0;

			textBox1.Text += n.ToString() + "! = " + m.ToString() + "\r\n";
			
			while (m >= 1) {
				m /= 10;
				c++;
			}
			
			textBox1.Text += "The number of digits in " + n.ToString() + "! equal to" + c.ToString() + "\r\n\r\n";
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.ScrollToCaret();
		}
	}
}
