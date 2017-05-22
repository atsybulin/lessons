/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 07.05.2017
 * Time: 20:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form11.
	/// </summary>
	public partial class Form11 : Form
	{
		public Form11()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Form11Load(object sender, EventArgs e)
		{
			dataGridView1.RowCount = 1;
//			int n = (int)numericUpDown1.Value;
			dataGridView1.ColumnCount = 10;
			for (int i = 0; i < 10; i++) {
				dataGridView1[i, 0].Value = "0";
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			for (int i = 0; i < 10; i++) {
				dataGridView1[i, 0].Value = rnd.Next(20).ToString();
			}
			button2.PerformClick();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int n = 0;
			int num;
			bool isNum;
			
			for (int i = 0; i < 10; i++) {
				isNum = int.TryParse(dataGridView1[i, 0].Value.ToString(), out num);
				if (isNum) {
					if (Math.Pow(num, 2) > 25) {
//						dataGridView1[i, 0].Style.BackColor = Color.GreenYellow;
						dataGridView1[i, 0].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
						n++;
						textBox1.Text += "Element " + i + ") " + num.ToString() + "^2 > 25\r\n";
					} else {
//						dataGridView1[i, 0].Style.BackColor = Color.White;
						dataGridView1[i, 0].Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
					}
				} else {
					textBox1.Text += "Element " + i + " - is not number\r\n";
				}
			}
			textBox1.Text += "Number of elements: " + n.ToString() + "\r\n\r\n";
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.ScrollToCaret();
		}
	}
}
