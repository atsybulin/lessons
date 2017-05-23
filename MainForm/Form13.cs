/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 21.05.2017
 * Time: 18:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form13.
	/// </summary>
	public partial class Form13 : Form
	{
		public Form13()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Form13Load(object sender, EventArgs e)
		{
			dataGridView1.RowCount = 1;
			dataGridView2.RowCount = 1;
		}
		void Button1Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			
			numericUpDown1.Value = rnd.Next(2, 30);
			button2.PerformClick();
			int n = (int)numericUpDown1.Value;
			for (int i = 0; i < n; i++) {
				dataGridView1[i, 0].Value = (rnd.Next(50) - 25).ToString();
			}
//			button3.Enabled = true;
			button3.PerformClick();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int n = (int)numericUpDown1.Value;
			dataGridView1.ColumnCount = n;
			for (int i = 0; i < n; i++) {
				dataGridView1[i, 0].Value = "0";
			}
			button3.Enabled = true;
		}
		void Button3Click(object sender, EventArgs e)
		{
			bool isNum1, isNum2, sort = true; //, unSort = false;
			int num1, num2, nus, i;
			
			int n = (int)numericUpDown1.Value;
			dataGridView2.ColumnCount = n;
			for (i = 0; i < n; i++) {
				dataGridView2[i, 0].Value = dataGridView1[i, 0].Value;
			}
			i = 0;
			while (sort && i < n - 1) {
				isNum1 = int.TryParse(dataGridView1[i, 0].Value.ToString(), out num1);
				isNum2 = int.TryParse(dataGridView1[i + 1, 0].Value.ToString(), out num2);
				if (isNum1 && isNum2) {
					if (num1 < num2) {
						sort = false;
						nus = i + 1;
						dataGridView2[i, 0].Value = num2.ToString();
						dataGridView2[i + 1, 0].Value = num1.ToString();
					}
				}
				i++;
			}
			if (sort) {
				dataGridView2[0, 0].Value = Math.Pow(int.Parse(dataGridView1[0, 0].Value.ToString()), 2).ToString();
				dataGridView2[n - 1, 0].Value = Math.Pow(int.Parse(dataGridView1[n - 1, 0].Value.ToString()), 2).ToString();
			}
			
			// вывод в лог
			for (i = 0; i < n; i++) {
				textBox1.Text += (i > 0 ? ", " : "Source array: ") + dataGridView1[i, 0].Value.ToString();
			}
			textBox1.Text += "\r\n";
			for (i = 0; i < n; i++) {
				textBox1.Text += (i > 0 ? ", " : "Result array: ") + dataGridView2[i, 0].Value.ToString();
			}
			textBox1.Text += "\r\n\r\n";
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.ScrollToCaret();
		}
	}
}
