using System;
using System.Windows.Forms;

namespace _29Enero20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float boleto = 80;
            float edad;
            float precio;
            string s_edad;
            string s_precio;

            s_edad = Box1.Text;
            edad = Convert.ToSingle(s_edad);

            if (edad >= 0 && edad <= 12)
            {
                precio = boleto * 0.6F;

                s_precio= Convert.ToString(precio);
                Text3.Text = "Su precio a pagar es de: $" + s_precio;
            }
            else if (edad > 12 && edad <= 25)
            {
                precio = boleto * 0.8F;

                s_precio = Convert.ToString(precio);
                Text3.Text = "Su precio a pagar es de: $" + s_precio;
            }
            else if (edad >= 26 && edad <= 64)
            {
                precio = boleto * 1F;

                s_precio = Convert.ToString(precio);
                Text3.Text = "Su precio a pagar es de: $" + s_precio;
            }
            else if (edad >= 65)
            {
                precio = boleto * 0.5F;

                s_precio = Convert.ToString(precio);
                Text3.Text = "Su precio a pagar es de: $" + s_precio;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Text1_Click(object sender, EventArgs e)
        {

        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text2_Click(object sender, EventArgs e)
        {

        }
    }
}
