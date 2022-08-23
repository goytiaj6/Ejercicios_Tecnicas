using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Febrero20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassLimpieza Limp = new ClassLimpieza();
        ClassJefeDepartamento J_D = new ClassJefeDepartamento();
        ClassProfAsignatura P_A = new ClassProfAsignatura();
        ClassResponsableLab R_L = new ClassResponsableLab();

        private void Limpieza_Click(object sender, EventArgs e)
        {
            Limp.trabajo();
            Limp.ficha_empleado("José Robles", 845, "HVG123HV21JVH2");
            DatosEmpleado.Text = " Nombre: " + Limp.nombre + "\r\n Número de empleado: " + Convert.ToString(Limp.Num_trabajador) + "\r\n RFC: " + Limp.RFC;
        }

        private void Jefe_Click(object sender, EventArgs e)
        {
            J_D.trabajo();
            J_D.ficha_empleado("Antonio Salazar", 1234, "ANDYEJ7521JVH2");
            DatosEmpleado.Text = " Nombre: " + J_D.nombre + "\r\n Número de empleado: " + Convert.ToString(J_D.Num_trabajador) + "\r\n RFC: " + J_D.RFC;
        }

        private void Laboratorio_Click(object sender, EventArgs e)
        {
            R_L.trabajo();
            R_L.ficha_empleado("Nicolás Bustamante", 737, "NSIDSUCJ21JVH2");
            DatosEmpleado.Text = " Nombre: " + R_L.nombre + "\r\n Número de empleado: " + Convert.ToString(R_L.Num_trabajador) + "\r\n RFC: " + R_L.RFC;
        }

        private void Asignatura_Click(object sender, EventArgs e)
        {
            P_A.trabajo();
            P_A.ficha_empleado("Hugo Mendoza", 1935, "HMDHBVEHV21JVH2");
            DatosEmpleado.Text = " Nombre: " + P_A.nombre + "\r\n Número de empleado: " + Convert.ToString(P_A.Num_trabajador) + "\r\n RFC: " + P_A.RFC;
        }

        private void Nomina_Click(object sender, EventArgs e)
        {
            Limp.pagar_nomina();
            J_D.pagar_nomina();
            P_A.pagar_nomina();
            R_L.pagar_nomina();
        }
    }
}