/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 16.05.2017
 * Time: 22:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form12.
	/// </summary>
	public partial class Form12 : Form
	{
		public Form12()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Form12Load(object sender, EventArgs e)
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
				dataGridView1[i, 0].Value = (rnd.Next(100) - 50).ToString();
			}
			button3.Enabled = true;
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
			bool isNum;
			int num, i;
			
			int n = (int)numericUpDown1.Value;
			dataGridView2.ColumnCount = n;
			for (i = 0; i < n; i++) {
				isNum = int.TryParse(dataGridView1[i, 0].Value.ToString(), out num);
				if (isNum) {
					dataGridView2[i, 0].Value = num < 0 ? (int.Parse(dataGridView1[i, 0].Value.ToString()) / 3) : dataGridView1[i, 0].Value;
				}
			}
			
			// вывод в лог
			for (i = 0; i < n; i++) {
				textBox1.Text += (i > 0 ? ", " : "Source array: ") + dataGridView1.Rows[0].Cells[i].Value.ToString();
			}
			textBox1.Text += "\r\n";
			for (i = 0; i < n; i++) {
				textBox1.Text += (i > 0 ? ", " : "Result array: ") + dataGridView2.Rows[0].Cells[i].Value.ToString();
			}
			textBox1.Text += "\r\n\r\n";
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.ScrollToCaret();
		}
	}
}
