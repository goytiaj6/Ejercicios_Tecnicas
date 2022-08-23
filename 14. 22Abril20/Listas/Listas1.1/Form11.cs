using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas1._1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        //*****Método para obtener números primos*****
        public List<int> GetPrimes(int start, int end) //Regresa una lista de enteros
        {
            List<int> primeList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num); //Método de la clase Math para calcular raíz cuadrada

                for(int div =2; div <= numSqrt; div++)
                {
                    if(num % div == 0)
                    {
                        prime = false;
                        break; //Sale de este ciclo aunque no lo haya terminado
                    }
                }

                if(prime == true)
                {
                    primeList.Add(num);
                }
            }
            return primeList;
        }//Fin del método


        string s = "";
        //Código del botón
        private void bttnGenerar_Click(object sender, EventArgs e)
        {
            int inf = Convert.ToInt32(textBox1.Text);
            int sup = Convert.ToInt32(textBox2.Text);

            List<int> primes = GetPrimes(inf, sup);
            
            for(int i=0; i < primes.Count; i++)
            {
                s = s + Convert.ToString(primes[i]) + "\r\n";
            }
            textBox3.Text = s;
        }
    }
}
