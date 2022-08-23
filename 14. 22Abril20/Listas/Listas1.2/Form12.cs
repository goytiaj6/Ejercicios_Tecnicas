using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas1._2
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Compras.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void Compras_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Compras.SelectedIndex + 1);
        }

        private void bttnBorrar_Click(object sender, EventArgs e)
        {
            Compras.Items.RemoveAt(Compras.SelectedIndex);
        }

        private void bttnVaciar_Click(object sender, EventArgs e)
        {
            Compras.Items.Clear();
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            bttnOK.Visible = true;
            textBox3.Visible = true;
            label2.Visible = true;
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            int index = Compras.SelectedIndex;
            Compras.Items.RemoveAt(Compras.SelectedIndex);
            Compras.Items.Insert(index, textBox3.Text);

            textBox3.Text = "";

            bttnOK.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
