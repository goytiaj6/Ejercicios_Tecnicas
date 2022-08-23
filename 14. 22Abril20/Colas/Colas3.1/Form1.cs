using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void bttnSucesion_Click(object sender, EventArgs e)
        {
            /*
             int n = 3, p = 16;

             Queue<int> cola = new Queue<int>();

             cola.Enqueue(n);

             int index = 0;

             string s = "Secuencia = ";

             while (cola.Count > 0)
             {
                 index++;
                 int current = cola.Dequeue();
                 s = s + Convert.ToString(current)+",";

                 if (current == p)
                 {
                     s = s + " Indice de p: " + Convert.ToString(index);
                     break;
                 }

                 cola.Enqueue(current+1);
                 cola.Enqueue(2 * current);
             }
             MessageBox.Show(s);
             */

            int n = Convert.ToInt32(textBox1.Text);

            Queue<int> cola = new Queue<int>();

            cola.Enqueue(n);

            int index = 0, s1, s2, s3;

            string s = "Secuencia = ";

            while (cola.Count > 0)
            {
                
                int current = cola.Dequeue();
                s = s + Convert.ToString(current) + ",";

                if (index == 49)
                {
                    break;
                }

                else
                {
                    index++;
                    s1 = current +1;
                    s2 = (2 * current) + 1;
                    s3 = current + 2;
                    cola.Enqueue(s1);
                    cola.Enqueue(s2);
                    cola.Enqueue(s3);
                }
            }
            MessageBox.Show(s);
        }
    }
}
