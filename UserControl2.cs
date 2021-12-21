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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int länge, breite, fläche;

            länge = Convert.ToInt32(textBox1.Text);
            breite = Convert.ToInt32(textBox2.Text);

            fläche = länge * breite;
            textBox3.Text = fläche.ToString("");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {



        }

        public void button3_Click(object sender, EventArgs e)
        {
            int länge, breite, umfang;

            länge = Convert.ToInt32(textBox1.Text);
            breite = Convert.ToInt32(textBox2.Text);

            umfang = 2 * länge + 2 * breite;
            textBox6.Text = umfang.ToString("");
        }

    }
}

