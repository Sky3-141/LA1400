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
    public partial class Form2 : Form
    {
        public string name;
        public string umfang;
        public string fläche;
        public string länge;
        public string breite;
        public Form1 mother;

        public Form2(Form1 mother)
        {
            InitializeComponent();
            this.mother = mother;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            double länge, breite, fläche;

            länge = Convert.ToDouble(textBox1.Text);
            breite = Convert.ToDouble(textBox2.Text);

            fläche = länge * breite;
            textBox3.Text = fläche.ToString("");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double länge1, breite1, umfang;

            länge1 = Convert.ToDouble(textBox1.Text);
            breite1 = Convert.ToDouble(textBox2.Text);

            umfang = 2 * (länge1 + breite1);
            textBox4.Text = umfang.ToString("");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mother.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            mother.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
