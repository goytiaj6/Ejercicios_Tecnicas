using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaListas
{
    public class Cola:Lista
    {
        public Cola() { }

        public Cola(string nombreCola)
        {
            nombre = nombreCola;
            primerNodo = ultimoNodo = null;
        }

        //Método queue
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

        //Método dequeue
        public override void EliminarFinal()
        {
            object Eliminado = null;
            
            try
            {
                if (EstaVacia() == true)
                {
                    throw new Exception("La cola " + nombre + " esta vacia");
                }

                Eliminado = ultimoNodo.Datos;
                
                if (primerNodo == ultimoNodo)
                {
                    primerNodo = ultimoNodo = null;
                }

                else
                {
                    NodoLista actual = primerNodo;

                    while (actual.Siguiente != ultimoNodo)
                    {
                        actual = actual.Siguiente;
                    }

                    ultimoNodo = actual;
                    actual.Siguiente = null;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Imprimimos la cola
        public override string Imprimir()
        {
            string cola = "";

            if (EstaVacia() == true)
            {
                cola = nombre + " esta vacia";
            }

            else
            {
                cola = cola + " " + nombre + " es: \n";
                NodoLista actual = primerNodo;
                
                while (actual != null)
                {
                    cola = cola + " " + Convert.ToString(actual.Datos) + "\n";
                    actual = actual.Siguiente;
                }
            }

            return cola;
        }
    }
}
