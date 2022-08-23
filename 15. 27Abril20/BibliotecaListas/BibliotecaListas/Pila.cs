using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaListas
{
    public class Pila:Lista
    {
        public Pila() { }

        public Pila(string nombrePila)
        {
            nombre = nombrePila;
            primerNodo = ultimoNodo = null;
        }

        //Método push
        public override void InsertarInicio(object elemento)
        {
            if (EstaVacia() == true)
            {
                primerNodo = ultimoNodo = new NodoLista(elemento);
            }

            else
            {
                primerNodo = new NodoLista(elemento, primerNodo);
            }
        }

        //Método pop
        public override object EliminarInicio()
        {
            object eliminado = null;
            
            try
            {
                if (EstaVacia() == true)
                {
                    throw new Exception("La pila " + nombre + " está vacia");
                }

                //Recupera el dato 
                eliminado = primerNodo.Datos;
                
                if (primerNodo == ultimoNodo)
                {
                    primerNodo = ultimoNodo = null;
                }
                
                else
                {
                    primerNodo = primerNodo.Siguiente;
                }
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            return eliminado;
        }

        //Imprimimos la pila
        public override string Imprimir()
        {
            string pila = "";
            
            if (EstaVacia() == true)
            {
                pila = nombre + " esta vacia";
            }
            
            else
            {
                pila = pila + " " + nombre + " es: \n";
                NodoLista actual = primerNodo;

                while (actual != null)
                {
                    pila = pila + " " + Convert.ToString(actual.Datos) + "\n";
                    actual = actual.Siguiente;
                }
            }

            return pila;
        }
    }
}
