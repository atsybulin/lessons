﻿/*
 * Created by SharpDevelop.
 * User: Nina
 * Date: 03.04.2017
 * Time: 23:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
			Form1 frm11 = new Form1();
			frm11.ShowDialog();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Form2 frm21 = new Form2();
			frm21.ShowDialog();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Form3 frm22 = new Form3();
			frm22.ShowDialog();
		}
		void Button4Click(object sender, EventArgs e)
		{
			Form4 frm23 = new Form4();
			frm23.ShowDialog();
		}
		void Button5Click(object sender, EventArgs e)
		{
			Form5 frm24 = new Form5();
			frm24.ShowDialog();
		}
		void Button6Click(object sender, EventArgs e)
		{
			Form6 frm31 = new Form6();
			frm31.ShowDialog();
		}
		void Button7Click(object sender, EventArgs e)
		{
			Form7 frm32 = new Form7();
			frm32.ShowDialog();
		}
		void Button8Click(object sender, EventArgs e)
		{
			Form8 frm33 = new Form8();
			frm33.ShowDialog();
		}
		void Button9Click(object sender, EventArgs e)
		{
			Form9 frm34 = new Form9();
			frm34.ShowDialog();
		}
		void Button10Click(object sender, EventArgs e)
		{
			Form10 frm35 = new Form10();
			frm35.ShowDialog();
		}
		void Button11Click(object sender, EventArgs e)
		{
			Form11 frm41 = new Form11();
			frm41.ShowDialog();
		}
		void Button12Click(object sender, EventArgs e)
		{
			Form12 frm42 = new Form12();
			frm42.ShowDialog();
		}
		void Button13Click(object sender, EventArgs e)
		{
			Form13 frm43 = new Form13();
			frm43.ShowDialog();
		}
		void Button14Click(object sender, EventArgs e)
		{
//			Form14 frm44 = new Form14();
//			frm44.ShowDialog();
		}
	}
}
