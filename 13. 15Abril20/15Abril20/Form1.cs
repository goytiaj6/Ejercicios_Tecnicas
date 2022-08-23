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

namespace _15Abril20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Guardar los cambios?", "Bloc de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
            textBox1.Text = " ";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Guardar los cambios?", "Bloc de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = (SR.ReadToEnd());
                SR.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.CheckFileExists == false)
            {
                StreamWriter SW = new StreamWriter(openFileDialog1.FileName);
                SW.WriteLine(textBox1.Text);
                MessageBox.Show("Guardado", "Bloc de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SW.Close();
            }
            else if (saveFileDialog1.CheckFileExists == true)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                SW.WriteLine(textBox1.Text);
                SW.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Guardar los cambios?", "Bloc de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter SW = new StreamWriter(saveFileDialog1.FileName + ".txt");
                    SW.WriteLine(textBox1.Text);
                    SW.Close();
                }
            }
            Application.Exit();
        }

        private void acercaDelBlockDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por: \n Jorge Goytia  Abril 2020", "Bloc de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
