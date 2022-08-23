using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _13Abril20
{
    public partial class frmPrincipal : Form
    {
        //Declaramos el objeto del tipo fileStream
        FileStream Archivo;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            byte[] datos = { 65, 66,67,68,69,70 };
            Archivo = new FileStream("Dato.txt", FileMode.Create, FileAccess.Write);
            Archivo.Write(datos, 0 ,6);
            Archivo.Close();
            */

            StreamWriter Escribir = new StreamWriter(textBox1.Text);
            Escribir.WriteLine(textBox2.Text);
            Escribir.Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            /*
             byte[] DatosLeidos = new byte[6];
             Archivo = new FileStream("Dato.txt", FileMode.Open, FileAccess.Read);
             Archivo.Read(DatosLeidos, 0, 6);
             Archivo.Close();

             lblLeído.Text = "";
             foreach (byte Dato in DatosLeidos)
                 lblLeído.Text += Convert.ToString(Dato);
            */

            StreamReader Leer = new StreamReader(textBox1.Text);
            lblLeído.Text = Leer.ReadToEnd();
            Leer.Close();
        }
    }
}
