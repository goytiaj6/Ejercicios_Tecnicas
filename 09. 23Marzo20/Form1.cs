using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _23Marzo20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empleado E1 = new Empleado("Jorge","Medina","53975938973","2500");
        Empleado E2 = new Empleado("Fernando", "Jimenez", "957303848637", "2500");
        Empleado E3 = new Empleado("Hugo", "Lopez", "8362058372784", "6800");
        Empleado E4 = new Empleado("Mauricio", "Bustamante", "0293472047323", "1200");

        string s = "";

        ArrayList ColeccionEmpleado;

        private void BttnPagar_Click(object sender, EventArgs e)
        {
            ColeccionEmpleado = new ArrayList { E1, E2, E3, E4 };

            for(int i = 0; i < ColeccionEmpleado.Count; i++)
            {
                s = s + Convert.ToString(ColeccionEmpleado[i]) + "\r\n";
            }

            s = s + "\r\n";

            ColeccionEmpleado.Sort();

            for (int i = 0; i < ColeccionEmpleado.Count; i++)
            {
                s = s + Convert.ToString(ColeccionEmpleado[i]) + "\r\n";
            }

            s = s + "\r\n";

            textBox1.Text = s;
        }
    }
}
