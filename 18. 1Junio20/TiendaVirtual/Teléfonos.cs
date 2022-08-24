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
    public partial class Teléfonos : Form
    {
        public Teléfonos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public Producto t1 = new Producto("Global Version Xiaomi Black Shark 2", 201, 16080);

        private void bttnComprar_Click(object sender, EventArgs e)
        {
            t1.agregarCarrito(t1);

            MessageBox.Show("                                                  \n" +
                            "                        Geek-ID                   \n" +
                            "  Favor de presentarse en su tienda               \n" +
                            "  más cercana con este ticket impreso.            \n" +
                            "                                                  \n" +
                            "  No. de pedido: 966302                           \n" +
                            "  Producto: No. 201                               \n" +
                            "  Nombre: Global Version Xiaomi Black Shark 2     \n" +
                            "  Precio: $16,080 MXN                             \n" +
                            "                                                  \n" +
                            "            Muchas gracias por su compra          \n" +
                            "                                                  \n");
            label4.Visible = true;
            bttnSí.Visible = true;
            bttnNo.Visible = true;
            bttnComprar.Enabled = false;
            bttnVolver.Enabled = false;
        }

        private void bttnVolver_Click(object sender, EventArgs e)
        {
            Form formulario = new PaginaPrincipal();
            formulario.Show();
            Visible = false;
        }

        private void bttnSí_Click(object sender, EventArgs e)
        {
            Form formulario = new PaginaPrincipal();
            formulario.Show();
            Visible = false;
        }

        private void bttnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Gracias por su compra \n ¡Vuleva pronto! ");
            Application.Exit();
        }
    }
}
