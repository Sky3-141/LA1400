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
    public partial class Form4 : Form
    {
        public Form1 mother;
        public Form4(Form1 mother)
        {
            InitializeComponent();
            this.mother = mother;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double seiteA, seiteB, fläche;

            seiteA = Convert.ToDouble(textBox2.Text);
            seiteB = Convert.ToDouble(textBox3.Text);

            fläche = (seiteA * seiteB) / 2;
            textBox1.Text = fläche.ToString("");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            mother.Show();
        }
    }
}
