using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private Color color = Color.White;
		public Form1()
		{
			InitializeComponent();
			label_Color.BackColor = color;
			for (int i = 0; i < 40; i++)
				dataGridView1.Rows.Add();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int col = e.ColumnIndex;
			int row = e.RowIndex;
			if (col < 0 || row < 0) return;
			DataGridViewCell cell = dataGridView1.Rows[row].Cells[col];
            cell.Style.BackColor = color;
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TextBox[] argbTB = new TextBox[] { textBox_R, textBox_G, textBox_B };
			int[] argb = new int[3];
			int i = 0;
			foreach(TextBox b in argbTB)
			{
				if(!int.TryParse(b.Text, out argb[i])){
					MessageBox.Show("ARGB值不是整数");
					return;
				}
				if(argb[i]<0 || argb[i] > 255)
				{
					MessageBox.Show("ARGB值不在0-255");
					return;
				}
				i++;
			}
			color = Color.FromArgb(255,argb[0], argb[1], argb[2]);
			label_Color.BackColor = color;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			for (int i = 0; i < 40; i++)
				dataGridView1.Rows.Add();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			color = Color.White;
			label_Color.BackColor = color;
		}

		private void button_Flip_Click(object sender, EventArgs e)
		{
			
			MessageBox.Show("试着画一颗心吧（比心）");
		}
	}
}
