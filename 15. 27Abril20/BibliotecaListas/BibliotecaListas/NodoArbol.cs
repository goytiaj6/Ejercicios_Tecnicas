using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaListas
{
    public class NodoArbol
    {
        public NodoArbol derecho;
        public NodoArbol izquierdo;
        public int dato; //Dato que se inserta

        //Constructor de nodos hoja (nodos que no tienen hijos):
        public NodoArbol(int valor)
        {
            dato = valor;  //es la raíz
            derecho = izquierdo = null;
        }

        //Método para insertar elementos en el arbol y que ignore valores repetidos
        /*Lo que hace es recibir el valor que se desea insertar, y si ese valor es menor que la raiz, pueden ocurrir dos cosas:*/
        public void Insertar(int valorInsercion)
        {
            if (valorInsercion < dato)  //si el valor que se desea insertar es menor que la raiz:
            {
                if (izquierdo == null)  //si la referencia izquierda del valor aiz es nula, es decir, si ya no hay otros nodos:
                {
                    izquierdo = new NodoArbol(valorInsercion);  //La referencia izquierda de la raiz se actualiza con el dato insertado
                }
                else  //si la referencia izquierda de la raiz NO es nula (si hay más nodos), continua recorriendo el subarbol
                {
                    izquierdo.Insertar(valorInsercion);  //se vuelve a llamar el metodo insertar, siempre con el valor de la izquierda
                }
            }

            if (valorInsercion > dato)  //si el valor que se desea insertar es mayor que la raiz:
            {
                if (derecho == null)  //si la referencia derecha del valor raiz es nula, es decir, si ya no hay otros nodos:
                {
                    derecho = new NodoArbol(valorInsercion);  //La referencia izquierda de la raiz se actualiza con el dato insertado
                }
                else  //si la referencia derecha de la raiz NO es nula (si hay más nodos), continua recorriendo el subarbol
                {
                    derecho.Insertar(valorInsercion);  //se vuelve a llamar el metodo insertar, siempre con el valor de la derecha
                }
            }

            //No esta programado el caso de que dos datos sean iguales, porque dos nodos no pueden ser iguales en un arbol
        }
    }
}
