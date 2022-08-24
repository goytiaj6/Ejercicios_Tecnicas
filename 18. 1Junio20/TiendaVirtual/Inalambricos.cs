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
    public partial class Inalambricos : Form
    {
        public Inalambricos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public Producto in1 = new Producto("Sony - Audífonos inalámbricos WH-CH510 - Negro", 302, 1100);

        private void bttnComprar_Click(object sender, EventArgs e)
        {
            in1.agregarCarrito(in1);

            MessageBox.Show("                                                          \n" +
                            "                            Geek-ID                       \n" +
                            "  Favor de presentarse en su tienda                       \n" +
                            "  más cercana con este ticket impreso.                    \n" +
                            "                                                          \n" +
                            "  No. de pedido: 769543                                   \n" +
                            "  Producto: No. 302                                       \n" +
                            "  Nombre: Sony - Audífonos inalámbricos WH-CH510 - Negro  \n" +
                            "  Precio: $1,100 MXN                                      \n" +
                            "                                                          \n" +
                            "                Muchas gracias por su compra              \n" +
                            "                                                          \n");
            label4.Visible = true;
            bttnSí.Visible = true;
            bttnNo.Visible = true;
            bttnComprar.Enabled = false;
            bttnVolver.Enabled = false;
        }

        private void bttnVolver_Click(object sender, EventArgs e)
        {
            Form formulario = new Audífonos();
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
