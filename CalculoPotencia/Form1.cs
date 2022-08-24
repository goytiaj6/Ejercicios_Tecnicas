using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoPotencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PotenciaRecursiva_Click(object sender, EventArgs e)
        {
            int BASE = Convert.ToInt32(textBox1.Text);
            int EXP = Convert.ToInt32(textBox2.Text);

            string POT = Convert.ToString(Pow(BASE, EXP));

            MessageBox.Show(" La potencia de: " + textBox1.Text + " \n elevado a la: " + textBox2.Text + " \n es: " + POT);
        }

        public double Pow(int Base, int exp)
        {
            if (exp == 0)
            {
                double pot = 1;
                return pot;
            }
            else if (exp < 0)
            {
                double pot;
                pot = 1 / (Pow(Base, exp*-1));
                return pot;
            }
            else
            {
                return Base * Pow(Base, exp-1);
            }
        }
    }
}
