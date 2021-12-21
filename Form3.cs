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
    public partial class Form3 : Form
    {
        public Form1 mother;

        public Form3(Form1 mother)
        {
            InitializeComponent();
            this.mother = mother;
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            mother.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double durchmesser, radius;
            durchmesser = Convert.ToDouble(textBox4.Text);
            radius = durchmesser / 2;

            textBox5.Text = radius.ToString("");
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double fläche, umfang;
            double pi = 3.14;
            double radius = Convert.ToDouble(textBox1.Text);

            fläche = radius * radius * pi;
            textBox2.Text = fläche.ToString("n");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double fläche, umfang;
            double pi = 3.14;
            double radius = Convert.ToDouble(textBox1.Text);

            umfang = 2 * radius * pi;
            textBox3.Text = umfang.ToString("n");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
