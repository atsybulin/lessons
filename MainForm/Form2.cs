/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 11.04.2017
 * Time: 15:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
      
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
  
		}
		void Label2Click(object sender, EventArgs e)
		{
  
		}
		void Button1Click(object sender, EventArgs e)
		{
			double x = double.Parse(textBox1.Text); // Парсим значение из значения Text элемента textBox1 
			double y = double.Parse(textBox2.Text); //
			bool A = (x * x > 1 / Math.Sqrt(y * y + 1)); // вычисляем А 
			bool B = (2 <= x * y + 2 * x * x);
			bool C = (3 + x >= 4);
			checkBox1.Text = A.ToString();
			checkBox1.Checked = A;
			checkBox2.Text = B.ToString();
			checkBox2.Checked = B;
			checkBox3.Text = C.ToString();
			checkBox3.Checked = C;
      
			bool L = (A ^ C) && (C || (!B));
			checkBox4.Text = L.ToString();
			checkBox4.Checked = L;
      
			textBox7.Text += "A=" + A + ", B=" + B + ", C=" + C + "\r\nResult: L = " + L + "\r\n\r\n";
			textBox7.SelectionStart = textBox7.Text.Length;
			textBox7.ScrollToCaret();
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = "1";
			textBox2.Text = "0";
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = "1";
			textBox2.Text = "1";
		}
	}
}
