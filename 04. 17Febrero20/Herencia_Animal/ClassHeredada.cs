using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia_Animal
{
    class Perro : Animal
    {
        public Perro()
        {

        }

        public Perro(string N, float P, float TLL)
        {
            Nombre = N;
            Peso = P;
            Talla = TLL;
        }

        public Perro(string N, string T)
        {
            Nombre = N;
            Tipo = T;
        }
    }
}
