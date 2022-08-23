using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24Febrero20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        int i;
        int[] arreglo;

        private void bttnTamaño_Click(object sender, EventArgs e)
        {
            i = 0;
            arreglo = new int[Convert.ToInt32(textBox1.Text)];
            bttnTamaño.Visible = false;
        }

        private void bttnDato_Click(object sender, EventArgs e)
        {
            if (i < arreglo.Length)
            {
                arreglo[i] = Convert.ToInt32(textBox2.Text);
                i++;
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Arreglo lleno");
                textBox2.Text = "";
                bttnDato.Visible = false;
            }
        }

        private void bttnSuma_Click(object sender, EventArgs e)
        {
            int Suma = 0;
            string arregloS = "";
            for (int j = 0; j < arreglo.Length; j++)
            {
                Suma = Suma + arreglo[j];
                arregloS = arregloS + Convert.ToString(arreglo[j]);

                if (j < arreglo.Length - 1)
                {
                    arregloS = arregloS + ",";
                }
                else
                {
                    arregloS = arregloS + "]";
                }
            }
            MessageBox.Show(" El arreglo es: [" + arregloS + "\n La suma de los elementos es: " + Suma);
        }
    }
}
