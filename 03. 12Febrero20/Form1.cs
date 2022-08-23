using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12Febrero20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool HC;

        Animal animalito = new Animal();

        private void BT1_Click(object sender, EventArgs e)
        {
            animalito = new Animal();
            animalito.Nombre = textBox1.Text;
            animalito.Tipo = textBox2.Text;
            animalito.Peso = Convert.ToSingle(textBox4.Text);
            animalito.Talla = Convert.ToSingle(textBox5.Text);

            textBox6.Text = "\r Se ha creado el animal que tiene los siguientes atributos: \r\n nombre: " + animalito.Nombre + "\r\n tipo: " + animalito.Tipo + " \r\n peso: " + Convert.ToString(animalito.Peso) + "\r\n talla: " + Convert.ToString(animalito.Talla);

            Animal animalito2 = new Animal("Boby", 100, 57.3F);
            MessageBox.Show("\r Ha llegado otro animal llamado: " + animalito2.Nombre + "\r\n tipo: perro" + " \r\n peso: " + Convert.ToString(animalito2.Peso) + "\r\n talla: " + Convert.ToString(animalito2.Talla));

            Animal animalito3 = new Animal("Pelusa", "gato");
            MessageBox.Show("\r Ha llegado otro animal llamado: " + animalito3.Nombre + " \r\n de tipo: " + animalito3.Tipo);
                  
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            animalito.Cansado = checkBox2.Checked;
            animalito.Alegre = checkBox4.Checked;

            if (animalito.Baño() == true)
            {
                MessageBox.Show(" A " + animalito.Nombre + " lo están bañando");
                MessageBox.Show(animalito.Nombre + " está durmiendo");               
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                textBox6.Text = "\r Se ha creado el animal que tiene los siguientes atributos: \r\n nombre: " + animalito.Nombre + "\r\n tipo: " + animalito.Tipo + " \r\n peso: " + Convert.ToString(animalito.Peso) + "\r\n talla: " + Convert.ToString(animalito.Talla);
            }
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            animalito.Hambre = checkBox1.Checked;
            HC = checkBox5.Checked;

            if (animalito.Comer(HC) == true)
            {
                MessageBox.Show(animalito.Nombre + " está comiendo");
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                textBox6.Text = "\r Se ha creado el animal que tiene los siguientes atributos: \r\n nombre: " + animalito.Nombre + "\r\n tipo: " + animalito.Tipo + " \r\n peso: " + Convert.ToString(animalito.Peso) + "\r\n talla: " + Convert.ToString(animalito.Talla);
            }
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            if (animalito.Triste() == true)
            {
                MessageBox.Show(animalito.Nombre + " está paseando por el parque");
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox2.Checked = true;
                textBox6.Text = "\r Se ha creado el animal que tiene los siguientes atributos: \r\n nombre: " + animalito.Nombre + "\r\n tipo: " + animalito.Tipo + " \r\n peso: " + Convert.ToString(animalito.Peso) + "\r\n talla: " + Convert.ToString(animalito.Talla);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            animalito.Hambre = checkBox1.Checked;

            if (animalito.Triste() == true)
            {
                MessageBox.Show(animalito.Nombre + " esta sad");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            animalito.Cansado = checkBox2.Checked;

            if (animalito.Triste() == true)
            {
                MessageBox.Show(animalito.Nombre + " esta dormido");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            animalito.Sed = checkBox3.Checked;

            if (animalito.Triste() == true)
            {
                MessageBox.Show(animalito.Nombre + " esta sad");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            animalito.Alegre = checkBox4.Checked;

            if (animalito.Triste() == false)
            {
                MessageBox.Show(animalito.Nombre + " esta moviendo la colita");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
