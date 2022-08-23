using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //*****Método para checar paréntesis*****
        public void CheckBrackets(string expression) //Método que no regresa algo
        {
            Stack<int> pila = new Stack<int>();
            bool correctBrackets = true;
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if ((c == '(') || (c == '[') || (c == '{'))//Si se abre paréntesis
                {
                    pila.Push(i);//Ingresa un elemento a cualquier pila
                }
                else if ((c == ')') || (c == ']') || (c == '}'))//Si se cierra paréntesis
                {
                    //Si no  hay elementos en la pila quiere decir que se cerraron paréntesis sin abrirlos, entonces:
                    if (pila.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    //Si hay elementos en la pila entonces elimina uno:
                    pila.Pop();
                }
            }//Fin del for
            
            //Como se insertan los elementos cuando se abren paréntesis y se quitan cuando se cierran, si se han puesto bien los paréntesis,
            //al final la longitud de la pila deberia ser cero, pero si no es cero, entonces:
            
            if (pila.Count != 0)
            {
                correctBrackets = false;
            }

            MessageBox.Show("¿Los corchetes son correctos? " + Convert.ToString(correctBrackets));
        }//Fin del método

        private void bttnVerificar_Click(object sender, EventArgs e)
        {
            string Expresion = textBox1.Text;
            CheckBrackets(Expresion);
        }
    }
}
