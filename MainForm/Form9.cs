/*
 * Created by SharpDevelop.
 * User: tsybulin
 * Date: 05.05.2017
 * Time: 15:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form9.
	/// </summary>
	public partial class Form9 : Form
	{
		public Form9()
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
			double sum1 = 1;
			double sum2 = 1;
			double sum3 = 1;
			int n;
			double x = (double)numericUpDown1.Value;
			
			// Way 1
			for (n = 1; n <= 5; n++) {
				sum1 *= 2 * x + Math.Sqrt(n);
			}
			
			// Way 2
			n = 1;
			while (n <= 5) {
				sum2 *= 2 * x + Math.Sqrt(n);
				n++;
			}
			
			//Way 3
			n = 1;
			do {
				sum3 *= 2 * x + Math.Sqrt(n);
				n++;
			} while (n <= 5);
			
			// Result
			textBox1.Text = sum1.ToString();
			textBox2.Text = sum2.ToString();
			textBox3.Text = sum3.ToString();
			
			textBox4.Text += "Sum by Way 1 = " + sum1.ToString() + "\r\n";
			textBox4.Text += "Sum by Way 2 = " + sum2.ToString() + "\r\n";
			textBox4.Text += "Sum by Way 3 = " + sum3.ToString() + "\r\n\r\n";
			textBox4.SelectionStart = textBox4.Text.Length;
			textBox4.ScrollToCaret();
		}
	}
}
