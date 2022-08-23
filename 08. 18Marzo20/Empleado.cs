using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Marzo20
{
    class Empleado : IPorPagar
    {
        public string PrimerNombre;
        public string ApellidoPaterno;
        public string NumSeguroSocial;
        public int Sueldo;

        //Constructor de cuatro parámetros
        public Empleado(string nombre, string apellido, string nss, int sueldo)
        {
            PrimerNombre = nombre;
            ApellidoPaterno = apellido;
            NumSeguroSocial = nss;
            Sueldo = sueldo;
        }

        public override string ToString()
        {
            return PrimerNombre + " | " + ApellidoPaterno + " | " + NumSeguroSocial + " | " + "$" + Convert.ToString(Sueldo);
        } //Fin del método to string

        public decimal ObtenerMontoPago()
        {
            Sueldo = Sueldo + 3000;
            return Sueldo;
        }
    }
}
