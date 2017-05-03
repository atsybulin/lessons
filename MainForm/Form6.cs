/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 30.04.2017
 * Time: 0:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form6.
	/// </summary>
	public partial class Form6 : Form
	{
		public Form6()
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
			double[] a = new double[n];
			a[0] = 1;
			a[1] = 4;
			a[2] = 1;
			double sum = 6;
			
			for (int i = 3; i < n; i++) {
				a[i] = a[i - 1] * Math.Sqrt(Math.Abs(a[i - 3])) + i * Math.Sin(a[i - 2]);
				sum += a[i];
			}
			
			textBox1.Text += "Sum " + n + " elements = " + sum.ToString() + "\r\n\r\n";
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.ScrollToCaret();
		}
	}
}
