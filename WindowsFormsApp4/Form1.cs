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
    public partial class Form1 : Form
    {
        public frmDesktop frmDesktop { get; private set; }
        public frmLaptop frmLaptop { get; private set; }
        public frmPriners frmPriners { get; private set; }
        public frmProduct frmProduct { get; private set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPriners = new frmPriners();
            this.Hide();
            frmPriners.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDesktop = new frmDesktop();
            this.Hide();
            frmDesktop.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLaptop = new frmLaptop();
            this.Hide();
            frmLaptop.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProduct = new frmProduct();
            this.Hide();
            frmProduct.ShowDialog();
        }
    }
}
