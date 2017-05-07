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
//			double m = factorial(n); // рекурсия
			double m = 1;
			for (int i = 2; i <= n; i++) {
				m *= i;
			}
			textBox1.Text += n.ToString() + "! = " + m.ToString() + "\r\n";

/*			2468.0 = 2*1000 + 4*100 + 6*10 + 8 * 1
			1) 2468.0 / 10 = 246.8  > 1  (c = 1)
			2) 246.8  / 10 = 24.68  > 1  (c = 2)
			3) 24.68  / 10 = 2.468  > 1  (c = 3)
			4) 2.468  / 10 = 0.2468 < 1  (c = 4)
*/
			int c = 0;

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
