using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Febrero20
{
    public abstract class Empleado
    {
        public string nombre;
        public string RFC;
        public int Num_trabajador;

        public abstract void pagar_nomina();
        public abstract void trabajo();
        public abstract void ficha_empleado(string N, int N_T, string RFC);
    }
}
