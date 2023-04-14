using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace troca_de_imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox.Visible= true;
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pictureBox.Visible= false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pictureBox.Visible = false;
            this.pictureBoxMostrar.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = true;
            this.pictureBox.Visible= true; 
        }
    }
}