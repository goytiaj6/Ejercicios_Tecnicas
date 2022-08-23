using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complejos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        string[] s1;
        string[] s2;
        Complejo c1;
        Complejo c2;
        Complejo c3;

        private void bttnSuma_Click(object sender, EventArgs e)
        {
            string s3;
            s1 = textBox1.Text.Split(',');
            c1 = new Complejo(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]));
            s2 = textBox2.Text.Split(',');
            c2 = new Complejo(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]));

            c3 = c1 + c2;
            if (c3.imaginario < 0)
            {
                s3 = Convert.ToString(c3.real) + Convert.ToString(c3.imaginario) + "i";
            }
            else
            {
                s3 = Convert.ToString(c3.real) + "+" + Convert.ToString(c3.imaginario) + "i";
            }

            MessageBox.Show("La suma de complejos es: " + s3);
        }

        private void bttnResta_Click(object sender, EventArgs e)
        {
            string s3;
            s1 = textBox1.Text.Split(',');
            c1 = new Complejo(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]));
            s2 = textBox2.Text.Split(',');
            c2 = new Complejo(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]));

            c3 = c1 - c2;
            if (c3.imaginario < 0)
            {
                s3 = Convert.ToString(c3.real) + Convert.ToString(c3.imaginario) + "i";
            }
            else
            {
                s3 = Convert.ToString(c3.real) + "+" + Convert.ToString(c3.imaginario) + "i";
            }

            MessageBox.Show("La resta de complejos es: " + s3);
        }

        private void bttnDivision_Click(object sender, EventArgs e)
        {
            string s3;
            s1 = textBox1.Text.Split(',');
            c1 = new Complejo(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]));
            s2 = textBox2.Text.Split(',');
            c2 = new Complejo(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]));

            c3 = c1 / c2;
            if (c3.imaginario < 0)
            {
                s3 = Convert.ToString(c3.real) + Convert.ToString(c3.imaginario) + "i";
            }
            else
            {
                s3 = Convert.ToString(c3.real) + "+" + Convert.ToString(c3.imaginario) + "i";
            }

            MessageBox.Show("La división de complejos es: " + s3);
        }

        private void bttnProduto_Click(object sender, EventArgs e)
        {
            string s3;
            s1 = textBox1.Text.Split(',');
            c1 = new Complejo(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]));
            s2 = textBox2.Text.Split(',');
            c2 = new Complejo(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]));

            c3 = c1 * c2;
            if (c3.imaginario < 0)
            {
                s3 = Convert.ToString(c3.real) + Convert.ToString(c3.imaginario) + "i";
            }
            else
            {
                s3 = Convert.ToString(c3.real) + "+" + Convert.ToString(c3.imaginario) + "i";
            }

            MessageBox.Show("El producto de complejos es: " + s3);
        }
    }
}
