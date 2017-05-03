/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 07.04.2017
 * Time: 0:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
		void Button1Click(object sender, EventArgs e)
		{
			double A = double.Parse(textBox1.Text);
			double B = double.Parse(textBox2.Text);
			double C = double.Parse(textBox3.Text);
      
			double Z = Math.Pow(A, Math.Abs(C - B));
			textBox4.Text = Z.ToString();
      
			double S = Z * (Math.Sin(Math.Log(Z)) + Math.Cos(Math.Log(Z)));
			textBox5.Text = S.ToString();
      
// 	  MainForm.textBox1.Text += "S = " + S.ToString();
		}
	}
}
