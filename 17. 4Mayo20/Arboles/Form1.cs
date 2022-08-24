using BibliotecaListas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        Arbol A1 = new Arbol();

        private void bttnInsertar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            A1.InsertarNodo(num);
            label3.Text = label3.Text + " " + textBox1.Text;
            textBox1.Text = "";
        }

        private void bttnRecorrer_Click(object sender, EventArgs e)
        {
            if(rdbttnInorden.Checked == true)
            {
                label5.Text = A1.RecorridoInorden();
                rdbttnInorden.Checked = false;
            }

            if(rdbttnPreorden.Checked == true)
            {
                label5.Text = A1.RecorridoPreorden();
                rdbttnPreorden.Checked = false;
            }

            if (rdbttnPostorden.Checked == true)
            {
                label5.Text = A1.RecorridoPostorden();
                rdbttnPostorden.Checked = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
