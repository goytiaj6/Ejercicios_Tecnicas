using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void CalculoFactorial_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            string Fact = Convert.ToString(Factorial(num));
            MessageBox.Show(" Factorial de " + textBox1.Text + " es: " + Fact);
        }

        public double Factorial(int num)
        {
            if (num <= 1)
            {
                return num = 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
