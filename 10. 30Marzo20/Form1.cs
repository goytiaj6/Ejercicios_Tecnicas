using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30Marzo20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            objetoEmisora.MiEvento += ObjetoEmisora_MiEvento1;
        }

        private void ObjetoEmisora_MiEvento1(string T)
        {
            MessageBox.Show(T);
        }

        int i = 0;
        Emisora objetoEmisora = new Emisora();

        private void button1_Click(object sender, EventArgs e)
        {
            if(i % 3 == 0)
            {
                objetoEmisora.LanzarEvento();
            }

            else
            {
                MessageBox.Show(Convert.ToString(i));
            }

            i++;
        }
    }
}
