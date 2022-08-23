using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaListas;

namespace _27Abril20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        Lista L1 = new Lista("Lista 1");
        Pila P1 = new Pila("Pila 1");
        Cola C1 = new Cola("Cola 1");

        private void InsertarInicio_Click(object sender, EventArgs e)
        {
            L1.InsertarInicio(textBox1.Text);
            textBox1.Text = "";
        }

        private void InsertarFinal_Click(object sender, EventArgs e)
        {
            L1.InsertatFinal(textBox1.Text);
            textBox1.Text = "";
        }

        private void EliminarInicio_Click(object sender, EventArgs e)
        {
            L1.EliminarInicio();
        }

        private void EliminarFinal_Click(object sender, EventArgs e)
        {
            L1.EliminarFinal();
        }

        private void ImprimirLista_Click(object sender, EventArgs e)
        {
            MessageBox.Show(L1.Imprimir());
        }

        private void InsertarPila_Click(object sender, EventArgs e)
        {
            P1.InsertarInicio(textBox2.Text);
            textBox2.Text = "";
        }

        private void EliminarPila_Click(object sender, EventArgs e)
        {
            P1.EliminarInicio();
        }

        private void ImprimirPila_Click(object sender, EventArgs e)
        {
            MessageBox.Show(P1.Imprimir());
        }

        private void InsertarCola_Click(object sender, EventArgs e)
        {
            C1.InsertatFinal(textBox3.Text);
            textBox3.Text = "";
        }

        private void EliminarCola_Click(object sender, EventArgs e)
        {
            C1.EliminarInicio();
        }

        private void ImprimirCola_Click(object sender, EventArgs e)
        {
            MessageBox.Show(C1.Imprimir());
        }
    }
}
