using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVirtual
{
    public partial class CancelarPedidos : Form
    {
        public CancelarPedidos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        Producto carro = new Producto();

        int index;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = carro.mostrar2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(textBox2.Text);
            button2.Enabled = false;
        }

        private void bttnBorrar_Click(object sender, EventArgs e)
        {
            carro.Borrar(index);
            button2.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ¡Vuleva pronto! ");
            Application.Exit();
        }

        private void bttnHome_Click(object sender, EventArgs e)
        {
            Form formulario = new PaginaPrincipal();
            formulario.Show();
            Visible = false;
        }
    }
}
