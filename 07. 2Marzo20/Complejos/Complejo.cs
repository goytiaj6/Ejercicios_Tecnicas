using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    class Complejo
    {
        public double real;
        public double imaginario;

        public Complejo() { }
        public Complejo(double R, double I)
        {
            real = R;
            imaginario = I;
        }

        //Método Suma
        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            double Real = 0;
            double Imaginario = 0;
            Real = c1.real + c2.real;
            Imaginario = c1.imaginario + c2.imaginario;
            return new Complejo(Real, Imaginario);
        }

        //Método Resta
        public static Complejo operator -(Complejo c1, Complejo c2)
        {
            double Real = 0;
            double Imaginario = 0;
            Real = c1.real - c2.real;
            Imaginario = c1.imaginario - c2.imaginario;
            return new Complejo(Real, Imaginario);
        }
        
        //Método Producto
        public static Complejo operator *(Complejo c1, Complejo c2)
        {
            double Real = 0;
            double Imaginario = 0;
            Real = (c1.real * c2.real) + (-1 * (c1.imaginario * c2.imaginario));
            Imaginario = (c1.real * c2.imaginario) + (c1.imaginario * c2.real);
            return new Complejo(Real, Imaginario);
        }

        //Método División
        public static Complejo operator /(Complejo c1, Complejo c2)
        {
            double Real = 0;
            double Imaginario = 0;
            Real = ((c1.real * c2.real) + (-1 * (c1.imaginario * (-1 * c2.imaginario)))) / ((c2.real * c2.real) + (c2.imaginario * c2.imaginario));
            Imaginario = ((c1.real * (-1 * c2.imaginario)) + (c1.imaginario * c2.real)) / ((c2.real * c2.real) + (c2.imaginario * c2.imaginario));
            return new Complejo(Real, Imaginario);
        }
    }
}
