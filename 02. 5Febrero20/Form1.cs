using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5Febrero20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtSuma_Click(object sender, EventArgs e)
        {
            int N;
            string S_N;
            S_N = Box1.Text;
            N = Convert.ToInt32(S_N);

            int suma;
            int i;
            suma = 0;
            for (i = 1; i <= N; i++)
            {
                suma = suma + i;
            }
            string sSuma = Convert.ToString(suma);
            MessageBox.Show("La suma de los números enteros es: " + sSuma);

        }

        private void BtFibonacci_Click(object sender, EventArgs e)
        {
            double n;
            string S_n;
            S_n = Box1.Text;
            n = Convert.ToDouble(S_n);
            string Fibonacci = " 1   ";
            double j;
            double a, b;
            a = 0;
            b = 1;

            for (j = 0; j <= n - 2; j++)
            {
                double fib;

                fib = a + b;
                a = b;
                b = fib;

                string S_fib;
                S_fib = Convert.ToString(fib);

                string Esp = "   ";
                Fibonacci = Fibonacci + S_fib + Esp;
            }
            MessageBox.Show("Fibonacci: " + Fibonacci);
        }

        private void BtSerie_Click(object sender, EventArgs e)
        {
            double form;
            double valor;
            double k;

            for (k = 1; k <= 10000; k++)
            {
                double Serie = 0;
                form = (-1 / k) * (Math.Pow(-1,k));
                valor = .0001;

                Serie = Serie + form;

                if((Math.Abs(form)) < valor)
                {
                    string S_k = Convert.ToString(k);
                    string S_serie = Convert.ToString(Serie);
                    MessageBox.Show("Suma de la serie: " + S_serie);
                    MessageBox.Show("Es el término: " + S_k);
                    break;
                }
            }
        }
    }
}
