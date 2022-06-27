using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание__2___Асимметричный_алгоритм_шифрования_RSA__3_
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
        
            double p = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add("Число p" + " " + p);
           
            double q = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add("Число q" + " " + q);
            double n = q * p;
            double o = (q - 1) * (p - 1);
            int f2 = 0;
          for(;f2<1000;f2++)
            {
                if(f2 %2!=0 && f2%3!=0 && o%f2!=0&&f2<o)
                {
                    break;

                }
            }
            listBox1.Items.Add("Рандомное число " + f2);
            int f1 = f2;
            int d = 0;

            for (; d < 1000; d++)
            {
                if (((d * f1) % o) == 1)
                {
                    break;
                }
            }
            
            Double P = Convert.ToInt32(textBox3.Text);
            Double E = Math.Pow(P, f2) % n;
            listBox1.Items.Add("E" + E);
            listBox1.Items.Add("Расшифровка");
            double S = Math.Pow(E, d) % n;
            listBox1.Items.Add("Сообщение" + " " + P + " " + "Расшифровка" + S);
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
