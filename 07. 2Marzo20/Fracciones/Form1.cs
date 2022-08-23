using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fracciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        string[] string1, string2;
        Fraccion frac1, frac2, FracRes;

        private void bttnSuma_Click(object sender, EventArgs e)
        {
            string1 = textBox1.Text.Split('/');
            frac1 = new Fraccion(Convert.ToInt32(string1[0]), Convert.ToInt32(string1[1]));
            string2 = textBox2.Text.Split('/');
            frac2 = new Fraccion(Convert.ToInt32(string2[0]), Convert.ToInt32(string2[1]));

            FracRes = frac1 + frac2;
            string s3 = Convert.ToString(FracRes.numerador) + "/" + Convert.ToString(FracRes.denominador);
            MessageBox.Show("El suma es: " + s3);
        }

        private void bttnResta_Click(object sender, EventArgs e)
        {
            string1 = textBox1.Text.Split('/');
            frac1 = new Fraccion(Convert.ToInt32(string1[0]), Convert.ToInt32(string1[1]));
            string2 = textBox2.Text.Split('/');
            frac2 = new Fraccion(Convert.ToInt32(string2[0]), Convert.ToInt32(string2[1]));

            FracRes = frac1 - frac2;
            string s3 = Convert.ToString(FracRes.numerador) + "/" + Convert.ToString(FracRes.denominador);
            MessageBox.Show("El resta es: " + s3);
        }

        private void bttnDivision_Click(object sender, EventArgs e)
        {
            string1 = textBox1.Text.Split('/');
            frac1 = new Fraccion(Convert.ToInt32(string1[0]), Convert.ToInt32(string1[1]));
            string2 = textBox2.Text.Split('/');
            frac2 = new Fraccion(Convert.ToInt32(string2[0]), Convert.ToInt32(string2[1]));

            FracRes = frac1 / frac2;
            string s3 = Convert.ToString(FracRes.numerador) + "/" + Convert.ToString(FracRes.denominador);
            MessageBox.Show("La división es: " + s3);
        }

        private void bttnProduto_Click(object sender, EventArgs e)
        {
            string1 = textBox1.Text.Split('/');
            frac1 = new Fraccion(Convert.ToInt32(string1[0]), Convert.ToInt32(string1[1]));
            string2 = textBox2.Text.Split('/');
            frac2 = new Fraccion(Convert.ToInt32(string2[0]), Convert.ToInt32(string2[1]));

            FracRes = frac1 * frac2;
            string s3 = Convert.ToString(FracRes.numerador) + "/" + Convert.ToString(FracRes.denominador);
            MessageBox.Show("El producto es: " + s3);
        }
    }
}
