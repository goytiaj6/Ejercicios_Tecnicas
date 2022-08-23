using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Animal
{
    class Animal
    {
        //Atribbutos de la clase animal
        public string Tipo, Nombre;
        public float Peso, Talla;
        public bool Hambre, Cansado, Sed, Alegre;

        //Constructor(s)
        //Vacio
        public  Animal()
        {

        }
        //Solo nombre
        public Animal(string N)
        {
            Nombre = N;
        }
        //De cadena
        public Animal(string N, string T)
        {
            Nombre = N;
            Tipo = T;
        }
        //De cadena (solo el nombre del animal)
        public Animal(string N, float P, float TLL)
        {
            Nombre = N;
            Peso = P;
            Talla = TLL;
        }
        //Métodos
        public bool Baño()
        {
            bool estoy_sucio = false;
            if (Cansado == true && Alegre == true)
            {
                estoy_sucio = true;
            }
            return estoy_sucio;
        }

        public bool Comer(bool hay_comida)
        {
            bool toca_sobre = false;
            if (Hambre == true && hay_comida == true)
            {
                toca_sobre = true;
                Peso = Peso + 12;
                Talla = Talla + .05F;
            }
            return toca_sobre;
        }
        public bool Paseo()
        {
            bool estoy_afuera = false;
            if (Alegre == false)
            {
                estoy_afuera = true;
                {
                    Peso = Peso - .57F;
                }
            }
            return estoy_afuera;
        }
        public bool Triste()
        {
            bool estoy_sad = false;
            if (Hambre == true && Sed == true)
            {
                estoy_sad = true;
            }
            return estoy_sad;
        }
    }
}
