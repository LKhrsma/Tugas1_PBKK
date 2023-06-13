using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas1_Aplikasi_Sederhana
{
	public partial class Form1 : Form
	{
		decimal bil1;
		decimal bil2;
		int opr;
		Boolean opr_done = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "1";
			}
			else
			{
				txtdis.Text += "1";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "5";
			}
			else
			{
				txtdis.Text += "5";
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "7";
			}
			else
			{
				txtdis.Text += "7";
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if(txtdis.Text != "0")
			{
				txtdis.Text += "0";
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			bil1 = Convert.ToDecimal(txtdis.Text);
			txtdis2.Text = "+";
			txtdis.Text = " ";
			opr = 4;
			opr_done = true;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if (opr_done == true)
				bil2 = Convert.ToDecimal(txtdis.Text);
			{
				switch (opr)
				{
					case 1:
						txtdis.Text = Convert.ToString(bil1 * bil2);
						txtdis2.Text = "=";
						break;
					case 2:
						txtdis.Text = Convert.ToString(bil1 / bil2);
						txtdis2.Text = "=";
						break;
					case 3:
						txtdis.Text = Convert.ToString(bil1 - bil2);
						txtdis2.Text = "=";
						break;
					case 4:
						txtdis.Text = Convert.ToString(bil1 + bil2);
						txtdis2.Text = "=";
						break;
				}
				opr_done = false;
			}
		}

		private void txtdis2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "2";
			}
			else
			{
				txtdis.Text = "2";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "3";
			}
			else
			{
				txtdis.Text += "3";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "4";
			}
			else
			{
				txtdis.Text += "4";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "6";
			}
			else
			{
				txtdis.Text += "6";
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "8";
			}
			else
			{
				txtdis.Text += "8";
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (txtdis.Text == "0")
			{
				txtdis.Text = "9";
			}
			else
			{
				txtdis.Text += "9";
			}
		}

		private void btnc_Click(object sender, EventArgs e)
		{
			txtdis.Text = "0";
			bil1 = 0;
			bil2 = 0;
			txtdis2.Text = " ";
		}

		private void btnkali_Click(object sender, EventArgs e)
		{
			bil1 = Convert.ToDecimal(txtdis.Text);
			txtdis2.Text = "x";
			txtdis.Text = " ";
			opr = 1;
			opr_done = true;
		}

		private void btnmin_Click(object sender, EventArgs e)
		{
			bil1 = Convert.ToDecimal(txtdis.Text);
			txtdis2.Text = "-";
			txtdis.Text = " ";
			opr = 3;
			opr_done = true;
		}

		private void btnbagi_Click(object sender, EventArgs e)
		{
			bil1 = Convert.ToDecimal(txtdis.Text);
			txtdis2.Text = "/";
			txtdis.Text = " ";
			opr = 2;
			opr_done = true;
		}

		private void textdis2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
