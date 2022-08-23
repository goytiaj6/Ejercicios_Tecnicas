using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18Marzo20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empleado Empleado1;
        Factura Factura1;
        string s;

    private void CheckEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckEmpleado.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void CheckFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckFactura.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void BttnPagar_Click(object sender, EventArgs e)
        {
            if (CheckEmpleado.Checked == false && CheckFactura.Checked == false)
            {
                MessageBox.Show(" No a seleccionado que ó a quien desea pagar ");
            }

            if (CheckEmpleado.Checked == true && CheckFactura.Checked == true)
            {
                MessageBox.Show(" Solo puede hacer un pago a la vez ");
                CheckEmpleado.Checked = false;
                CheckFactura.Checked = false;
            }

            if (CheckEmpleado.Checked == true)
            {
                int sueldo = 500;
                Empleado1 = new Empleado(textBox1.Text, textBox2.Text, textBox3.Text, sueldo);
                Empleado1.ObtenerMontoPago();
                s = Convert.ToString(Empleado1);
                MessageBox.Show(s);
                CheckEmpleado.Checked = false;
            }

            if (CheckFactura.Checked == true)
            {
                decimal precio = 250;
                Factura1 = new Factura(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), precio);
                Factura1.ObtenerMontoPago();
                s = Convert.ToString(Factura1);
                MessageBox.Show(s);
                CheckFactura.Checked = false;
            }
        }
    }
}
