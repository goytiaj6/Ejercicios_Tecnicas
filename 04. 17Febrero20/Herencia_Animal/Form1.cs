using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia_Animal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Perro perro1 = new Perro();

        Perro perro2 = new Perro("Boby", 100F, 57.3F);    

        Perro perro3 = new Perro("Manchas", "dálmata");

        private void OK_Click(object sender, EventArgs e)
        {
            perro1 = new Perro();
            perro1.Nombre = NombreBox.Text;
            perro1.Tipo = TipoBox.Text;
            perro1.Peso = Convert.ToSingle(PesoBox.Text);
            perro1.Talla = Convert.ToSingle(TallaBox.Text);

            Perro1Box.Text = "\r Se ha creado el perro con los siguientes atributos: \r\n nombre: " + perro1.Nombre + "\r\n tipo: " + perro1.Tipo + " \r\n peso: " + Convert.ToString(perro1.Peso) + "\r\n talla: " + Convert.ToString(perro1.Talla);

            MessageBox.Show("\r Ha llegado otro perro llamado: " + perro2.Nombre + "\r\n tipo: labrador" + " \r\n peso: " + Convert.ToString(perro2.Peso) + "\r\n talla: " + Convert.ToString(perro2.Talla));
            
            MessageBox.Show("\r Ha llegado otro perro llamado: " + perro3.Nombre + " \r\n de tipo: " + perro3.Tipo);

            MessageBox.Show(" Lograste crear perros por herencia ");
        }
    }
}
