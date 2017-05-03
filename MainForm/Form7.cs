/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 01.05.2017
 * Time: 17:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of Form7.
	/// </summary>
	public partial class Form7 : Form
	{
		public Form7()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			dataGridView1.RowCount = 1;
			int n = (int)numericUpDown1.Value;
			dataGridView1.ColumnCount = n;
			for (int i = 0; i < n; i++) {
				dataGridView1[i, 0].Value = "0";
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			int n = (int)numericUpDown1.Value;
			
			int[] a = new int[n];
			
			for (int i = 0; i < n; i++) {
				a[i] = int.Parse(dataGridView1[i, 0].Value.ToString());
			}
			int sum = a[0] + a[1];
			int max = sum;
			int a1 = 0;
			for (int i = 1; i < n - 1; i++) {
				if ((sum = a[i] + a[i + 1]) > max) {
					max = sum;
					a1 = i;
				}
			}
			textBox1.Text += "First MAX is " + max.ToString() + "\r\nindex of " + a1.ToString() + " and " + (a1 + 1).ToString() + " (begin from 0)\r\n\r\n";
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.ScrollToCaret();
		}
	}
}
