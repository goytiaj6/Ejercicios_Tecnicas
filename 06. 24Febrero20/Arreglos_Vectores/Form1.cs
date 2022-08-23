using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        int[] vector1 = new int[3];
        int[] vector2 = new int[3];
        int[] Suma = new int[3];
        int[] Resta = new int[3];
        int[] ProdVec = new int[3];

        private void bttnVect1_Click(object sender, EventArgs e)
        {
            vector1[0] = Convert.ToInt32(textBox1.Text);
            vector1[1] = Convert.ToInt32(textBox2.Text);
            vector1[2] = Convert.ToInt32(textBox3.Text);
            bttnVect1.Visible = false;
        }

        private void bttnVect2_Click(object sender, EventArgs e)
        {
            vector2[0] = Convert.ToInt32(textBox4.Text);
            vector2[1] = Convert.ToInt32(textBox5.Text);
            vector2[2] = Convert.ToInt32(textBox6.Text);
            bttnVect2.Visible = false;
        }

        private void bttnOperaciones_Click(object sender, EventArgs e)
        {
            int ProdEsc = 0;

            if ((bttnVect1.Visible == true) && (bttnVect2.Visible == true))
            {
                MessageBox.Show("Falta un vector");
            }
            else
            {
                for (int i = 0; i < vector1.Length; i++)
                {
                    Suma[i] = vector1[i] + vector2[i];
                    Resta[i] = vector1[i] - vector2[i];
                    ProdEsc = ProdEsc + vector1[i] * vector2[i];
                }
                ProdVec[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
                ProdVec[1] = -1 * (vector1[0] * vector2[2]) - (vector1[2] * vector2[0]);
                ProdVec[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
                MessageBox.Show("Vector1:  [" + vector1[0] + ", " + vector1[1] + ", " + vector1[2] + "]     \nVector2: [" + vector2[0] + ", " + vector2[1] + ", " + vector2[2] + "]\n\nLa suma de vectores es: [" + Suma[0] + "," + Suma[1] + "," + Suma[2] + "]\nLa resta de vectores es: [" + Resta[0] + ", " + Resta[1] + ", " + Resta[2] + "]\nEl producto escalar es: " + Convert.ToString(ProdEsc) + "\nEl producto vectorial es: [" + ProdVec[0] + ", " + ProdVec[1] + ", " + ProdVec[2] + "]");
            }
        }
    }
}
