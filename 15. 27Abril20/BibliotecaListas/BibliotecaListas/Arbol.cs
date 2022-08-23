using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaListas
{
    public class Arbol
    {
        //Para construir un arbol solo necesito una raiz y a partir de ella puedo ir añadiendo datos
        public NodoArbol raiz;

        public Arbol() { raiz = null; } //Constructor vacio

        //Metodo que inserta nuevo nodo en el arbol. Si la raiz está vacia crea el nodo raíz; sino esta vacia
        //manda llamar el metodo insertar
        public void InsertarNodo(int valorInsercion)
        {
            if(raiz == null) { raiz = new NodoArbol(valorInsercion); }  //Es decir, si no existe la raíz, la crea con ese valor
            else  //si la raiz no esta vacia entonces si puede insertar elementos
            {
                raiz.Insertar(valorInsercion);
            }
        }

        //Método que hace un recorrido del tipo Preorden: inicia en la raiz, pasa a la izquierda y luego a la derecha
        private string AyudantePreorden(NodoArbol nodo)  //Este método recibe un nodo: la raiz
        {
            if(nodo == null) { return ""; }
            string s = "";
            s = s + Convert.ToString(nodo.dato) + " ";  //Inicia en la raiz (al centro) e imprime ese valor
            s = s + AyudantePreorden(nodo.izquierdo) + " ";  /*Despues se pasa a la izquierda. Llama al método cuyo argumento es el nodo
            izquierdo, de tal forma que está sera la "nueva raíz", asi que lo imprime al lado del nodo anterior. De forma explícita
            el argumento de AyudantePreorden en un n-simo llamado seria: s = s + Convert.ToString(nodo.izquierdo.dato);*/
            s = s + AyudantePreorden(nodo.derecho) + " ";  //Por último se va al derecho
            return s;
        }

        public string RecorridoPreorden()
        {
            string s = AyudantePreorden(raiz);  //AyudantePreorden toma como argumento a la raiz que es el primer valor ingresado
            return s;
        }

        //Método que hace un recorrido del tipo InOrden: inicia en la izquierda, pasa a la raiz y luego a la derecha
        public string RecorridoInorden()
        {
            string s = AyudanteInorden(raiz);  //recibe la raiz como argumento
            return s;
        }

        private string AyudanteInorden(NodoArbol nodo)  //Está será la raiz al momento de mandar llamar este metodo
        {
            if (nodo == null) { return ""; }
            string s = "";
            s = s + AyudanteInorden(nodo.izquierdo) + " ";  //Inicia con el nodo izquierdo
            s = s + Convert.ToString(nodo.dato) + " ";
            s = s + AyudanteInorden(nodo.derecho) + " ";
            return s;
        }

        //Método que hace un recorrido del tipo Postorden: inicia en la izquierda, pasa a la derecha y luego a la raiz
        public string RecorridoPostorden()
        {
            string s = AyudantePostorden(raiz);  //recibe la raiz como argumento
            return s;
        }

        private string AyudantePostorden(NodoArbol nodo)  //Está será la raiz al momento de mandar llamar este metodo
        {
            if (nodo == null) { return ""; }
            string s = "";
            s = s + AyudantePostorden(nodo.izquierdo) + " ";  //Inicia con el nodo izquierdo
            s = s + AyudantePostorden(nodo.derecho) + " ";  //Luego se va a la derecha
            s = s + Convert.ToString(nodo.dato) + " ";
            return s + " ";
        }
    }
}
