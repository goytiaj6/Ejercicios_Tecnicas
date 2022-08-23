using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23Marzo20
{
    class Empleado : IPorPagar, IComparable
    {
        public string PrimerNombre;
        public string ApellidoPaterno;
        public string NumSeguroSocial;
        public int Sueldo;

        //Constructor de cuatro parámetros
        public Empleado(string nombre, string apellido, string nss, string sueldo)
        {
            PrimerNombre = nombre;
            ApellidoPaterno = apellido;
            NumSeguroSocial = nss;
            Sueldo = Convert.ToInt32(sueldo);
        }

        /*public int CompareTo(object other)
        {
            Empleado otro = (Empleado)other;
            return string.Compare(PrimerNombre, otro.PrimerNombre);
        } //Fin del método compare*/

        public int CompareTo(object other)
        {
            Empleado otro = (Empleado)other;

            int j = string.Compare(Convert.ToString(Sueldo), Convert.ToString(otro.Sueldo));
            MessageBox.Show(" La comparación de " + Convert.ToString(Sueldo) + " y " +  Convert.ToString(otro.Sueldo) + " da " + Convert.ToString(j));
            

            return string.Compare(Convert.ToString(Sueldo), Convert.ToString(otro.Sueldo));
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
