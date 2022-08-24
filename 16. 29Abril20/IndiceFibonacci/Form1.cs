using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndiceFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void IndiceFibonacci_Click(object sender, EventArgs e)
        {
            string sucesion = "";
            int indice = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= indice; i++)
            {
                sucesion = sucesion + Convert.ToString(Fibonacci(i)) + " ";
            }
            MessageBox.Show(" Sucesión de Fibonacci: " + sucesion);
        }

        public int Fibonacci(int indice)
        {
            if (indice == 1 || indice == 2)
                return indice = 1;
            else
            {
                return indice = Fibonacci(indice-1) + Fibonacci(indice-2);
            }
        }
    }
}
