using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_RSA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double g = Convert.ToInt32(textBox1.Text);
            double p = Convert.ToInt32(textBox2.Text);
            double a = Convert.ToInt32(textBox3.Text);
            double b = Convert.ToInt32(textBox4.Text);
         

            Double A = Math.Pow(g, a) % p;
            listBox1.Items.Add ("Считаем А" + " " + A);

            Double B = Math.Pow(g, b) % p;
            listBox1.Items.Add("Считаем B" + " " + b
                );

            Double Ka = Math.Pow(B, a) % p;
            listBox1.Items.Add("Считаем Ka" + " " + Ka);

            Double Kb = Math.Pow(A, b) % p;
            listBox1.Items.Add("Считаем Kb" + " " + Kb);
            Double k = Math.Pow(g, a * b) % p;
            listBox1.Items.Add("K" + " " + k);
            listBox1.Items.Add("Ka" + "=" + " " + Ka + " " + " Kb" + "=" + " " + Kb);
          
        }
    }
}
