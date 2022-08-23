using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaListas
{
    public class Lista
    {
        public NodoLista primerNodo;
        public NodoLista ultimoNodo;
        public string nombre;

        public Lista() { }

        //Constructor de lista vacia 
        public Lista(string nombreLista)
        {
            nombre = nombreLista;
            primerNodo = ultimoNodo = null;
        }
        
        //Preguntamos si esta vacia
        virtual public bool EstaVacia()
        {
            bool bandera = false;
            
            if (primerNodo == null)
            {
                bandera = true;
            }
            
            return bandera;
        }

        //Insertar elementos a la lista al inicio de ella
        virtual public void InsertarInicio(object elemento)
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

        //Insertar elementos a la lista al final de ella
        public void InsertatFinal(object elemento)
        {
            if (EstaVacia() == true)
            {
                primerNodo = ultimoNodo = new NodoLista(elemento);
            }

            else
            {
                ultimoNodo = ultimoNodo.Siguiente = new NodoLista(elemento);
            }
        }

        //Eliminar elementos de la lista al inicio de ella
        virtual public object EliminarInicio()
        {
            object eliminado = null;
            
            try
            {
                if (EstaVacia() == true)
                {
                    throw new Exception("La lista " + nombre + " está vacia");
                }

                //Recuperamos el dato 
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

        //Eliminar elementos de la lista al final de ella
        virtual public void EliminarFinal()
        {
            object Eliminado = null;
            
            try
            {
                if (EstaVacia() == true)
                {
                    throw new Exception("La lista " + nombre + " esta vacia");
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

        //Imprimir la lista
        virtual public string Imprimir()
        {
            string lista = "";
            
            if (EstaVacia() == true)
            {
                lista = nombre + " esta vacia";
            }
            
            else
            {
                lista = lista + " " + nombre + " es: \n";
                NodoLista actual = primerNodo;
                
                while (actual != null)
                {
                    lista = lista + " " + Convert.ToString(actual.Datos) + "\n";
                    actual = actual.Siguiente;
                }
            }
            
            return lista;
        }
    }
}
