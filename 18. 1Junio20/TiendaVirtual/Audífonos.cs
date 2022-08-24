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
    public partial class Audífonos : Form
    {
        public Audífonos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void bttnHome_Click(object sender, EventArgs e)
        {
            Form formulario = new PaginaPrincipal();
            formulario.Show();
            Visible = false;
        }

        private void bttnAudífonos_Click(object sender, EventArgs e)
        {
            Form formulario = new Alambricos();
            formulario.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Inalambricos();
            formulario.Show();
            Visible = false;
        }
    }
}
