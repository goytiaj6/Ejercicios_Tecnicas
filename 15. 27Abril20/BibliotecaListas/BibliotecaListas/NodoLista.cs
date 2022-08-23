using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaListas
{
    public class NodoLista
    {
        private object datos;
        private NodoLista siguiente;

        //constructor vacio 
        public NodoLista() { }

        public NodoLista(object valor)
        {
            datos = valor;
            siguiente = null;
        }

        //Constructor sin referencia al nodo siguiente 
        public NodoLista(object valor, NodoLista Nodosig)
        {
            datos = valor;
            siguiente = Nodosig;
        }

        //propiedad siguiente 
        public NodoLista Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        //propiedad Datos
        public object Datos
        {
            get { return datos; }
        }
        //fin nodo lista
    }
}
