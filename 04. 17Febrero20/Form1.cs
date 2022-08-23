using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17Febrero20
{
    public partial class Form1 : Form
    {
        Alimento Pastel = new Alimento();
        float SalR = 1.3F;

        public Form1()
        {
            InitializeComponent();
            Pastel.Sal_receta(SalR);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cocinar_Click(object sender, EventArgs e)
        {
            float SAL_RECIPE = Pastel.Sal_alimento();
            textBox1.Text = " Pastel de chocolate \r\n Cantidad de sal : " + Convert.ToString(SAL_RECIPE) + " [g] ";
        }

        private void Ingrediente_Click(object sender, EventArgs e)
        {
            Pastel.G_SECRETO = 5.3F;
            MessageBox.Show(" Se ha agregado cacao en polvo y chocolate amargo ");
        }

        private void Sal_Click(object sender, EventArgs e)
        {
            float SAL_RECIPE = Pastel.Sal_alimento();
            SAL_RECIPE = SAL_RECIPE + .75F;
            Pastel.Sal_receta(SAL_RECIPE);
            textBox1.Text = " Pastel de chocolate \r\n sal : " + Convert.ToString(SAL_RECIPE) + " [g] \r\n Se agrego una pizca más de azúcar ";
            Pastel.AZÚCAR = Pastel.AZÚCAR + 1.2F;
        }

        private void Cambios_Click(object sender, EventArgs e)
        {
            textBox1.Text = " Cantidad de Azucar =  " + Pastel.AZÚCAR + "\r\n Se ha agregado más del ingrediente secreto ";
            Pastel.G_SECRETO = Pastel.G_SECRETO + .8F;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
