using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcVectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        double[] v1 = new double[3];
        double[] v2 = new double[3];
        double[] v3 = new double[3];

        int num = 0;

        private void SumaVectorial_Click(object sender, EventArgs e)
        {
            v1[0] = Convert.ToDouble(textBox1.Text);
            v1[1] = Convert.ToDouble(textBox2.Text);
            v1[2] = Convert.ToDouble(textBox3.Text);
            v2[0] = Convert.ToDouble(textBox4.Text);
            v2[1] = Convert.ToDouble(textBox5.Text);
            v2[2] = Convert.ToDouble(textBox6.Text);

            SumaVec(num);
        }

        private void ProductoVectorial_Click(object sender, EventArgs e)
        {
            v1[0] = Convert.ToDouble(textBox1.Text);
            v1[1] = Convert.ToDouble(textBox2.Text);
            v1[2] = Convert.ToDouble(textBox3.Text);
            v2[0] = Convert.ToDouble(textBox4.Text);
            v2[1] = Convert.ToDouble(textBox5.Text);
            v2[2] = Convert.ToDouble(textBox6.Text);

            ProductoVec(num);
        }

        public void SumaVec(int i)
        {

            //Componente a componente

            if (i == 3)
            {
                string V = "";

                for (int n = 0; n < i; n++)
                {
                    V = V + Convert.ToString(v3[n]) + "\n";
                }

                MessageBox.Show("La suma de vectores componente a componente es : " + "\n" + V);
            }
            else
            {
                v3[i] = v1[i] + v2[i];
                SumaVec(i + 1);
            }
        }

        public void ProductoVec(int i)
        {

            //Componente a componente

            if (i == 3)
            {
                string V = "";

                for (int n = 0; n < i; n++)
                {
                    V = V + Convert.ToString(v3[n]) + "\n";
                }

                MessageBox.Show("El producto de vectores componente a componente es : " + "\n" + V);
            }
            else
            {
                v3[i] = v1[i] * v2[i];
                ProductoVec(i + 1);
            }
        }
    }
}
