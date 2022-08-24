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
    public partial class Consolas : Form
    {
        public Consolas()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public Producto c1 = new Producto("Consola Xbox One X 1tb  Color Negro", 101, 10000);
        
        private void bttnComprar_Click(object sender, EventArgs e)
        {

            c1.agregarCarrito(c1);

            MessageBox.Show("                                                  \n" +
                            "                        Geek-ID                   \n" +
                            "  Favor de presentarse en su tienda               \n" +
                            "  más cercana con este ticket impreso.            \n" +
                            "                                                  \n" +
                            "  No. de pedido: 453953                           \n" +
                            "  Producto: No. 101                               \n" +
                            "  Nombre: Consola Xbox One X 1tb  Color Negro     \n" +
                            "  Precio: $10,000 MXN                             \n" +
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
