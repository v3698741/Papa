using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st25DataSet.GG". При необходимости она может быть перемещена или удалена.
            this.gGTableAdapter.Fill(this.st25DataSet.GG);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private System.Windows.Forms.DataGridViewColumn Col;
        private void button1_Click(object sender, EventArgs e)
        {
            Col = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
            }
            if (radioButton1.Checked)
                gGDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                gGDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gGBindingSource.Filter = "Name='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gGBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i=0; i<gGDataGridView.ColumnCount-1;i++)
            {
                for (int j = 0; j < gGDataGridView.ColumnCount - 1; j++)
                {
                    gGDataGridView[i, j].Style.BackColor = Color.White;
                    gGDataGridView[i, j].Style.BackColor = Color.Black;
                }
            }
            for (int i = 0; i < gGDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < gGDataGridView.ColumnCount - 1; j++)
                {
                    if (gGDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text)!=-1)
                    {
                        gGDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        gGDataGridView[i, j].Style.BackColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
