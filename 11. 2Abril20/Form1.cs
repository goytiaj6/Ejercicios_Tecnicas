using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosRatón
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool debePintar = false; 
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            debePintar = true; 
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            debePintar = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(debePintar == true)
            {
                Graphics G1 = CreateGraphics();
                SolidBrush SB1 = new SolidBrush(Color.Red);
                G1.FillEllipse(SB1,e.X,e.Y,5,5);
            }
            
        }
    }
}
