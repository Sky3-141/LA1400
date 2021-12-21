using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolat.FormCalculator
{
    public partial class Form1 : Form
    {
        public String name;
        

        public Form1()
        {
            InitializeComponent();
           
            label2.Visible = false;
            comboBox1.Visible = false;
            button2.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            label2.Visible = true;
            comboBox1.Visible = true;
            button2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form3 circleCalculator = new Form3(this);
                circleCalculator.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Form4 triangleCalculator = new Form4(this);
                triangleCalculator.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form2 rechteck = new Form2(this);              
                rechteck.Show();
                this.Hide();
            }
        }
    }
}
