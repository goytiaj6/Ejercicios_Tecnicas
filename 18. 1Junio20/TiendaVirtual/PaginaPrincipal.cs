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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        
        private void bttnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ¡Vuleva pronto! ");
            Application.Exit();
        }

        private void bttnConsolas_Click(object sender, EventArgs e)
        {
            Form formulario = new Consolas();
            formulario.Show();
            Visible = false;
        }

        private void bttnTeléfonos_Click(object sender, EventArgs e)
        {
            Form formulario = new Teléfonos();
            formulario.Show();
            Visible = false;
        }

        private void bttnAudífonos_Click(object sender, EventArgs e)
        {
            Form formulario = new Audífonos();
            formulario.Show();
            Visible = false;
        }

        private void bttnCarrito_Click(object sender, EventArgs e)
        {
            Producto carro = new Producto();
            carro.mostrar();
        }

        private void bttnCancelaPedido_Click(object sender, EventArgs e)
        {
            Form formulario = new CancelarPedidos();
            formulario.Show();
            Visible = false;
        }
    }
}
