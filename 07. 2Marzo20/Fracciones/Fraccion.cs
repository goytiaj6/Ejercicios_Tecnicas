using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    class Fraccion
    {
        public int numerador;
        public int denominador;
        public Fraccion() { }
        public Fraccion(int N, int D)
        {
            numerador = N;
            denominador = D;
        }

        //Conversion de fracción
        public static explicit operator double(Fraccion f1)
        {
            double dn1 = (double)f1.numerador;
            double dd1 = (double)f1.denominador;

            return dn1 / dd1;
        }

        //Método Suma
        public static Fraccion operator +(Fraccion f1, Fraccion f2)
        {
            int num = 0;
            int den = 0;

            num = (f1.numerador * f2.denominador) + (f2.numerador * f1.denominador);
            den = f1.denominador * f2.denominador;
            return new Fraccion(num, den);
        }

        //Método Resta
        public static Fraccion operator -(Fraccion f1, Fraccion f2)
        {
            int num = 0;
            int den = 0;
            num = (f1.numerador * f2.denominador) - (f2.numerador * f1.denominador);
            den = f1.denominador * f2.denominador;
            return new Fraccion(num, den);
        }

        //Método división
        public static Fraccion operator /(Fraccion f1, Fraccion f2)
        {
            int num = 0;
            int den = 0;
            num = f1.numerador * f2.denominador;
            den = f1.denominador * f2.numerador;
            return new Fraccion(num, den);
        }

        //Método producto
        public static Fraccion operator *(Fraccion f1, Fraccion f2)
        {
            int num = 0;
            int den = 0;
            num = f1.numerador * f2.numerador;
            den = f1.denominador * f2.denominador;
            return new Fraccion(num, den);
        }
    }
}
