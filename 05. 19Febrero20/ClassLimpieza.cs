using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Febrero20
{
    public class ClassLimpieza : Empleado
    {
        public override void pagar_nomina()
        {
            MessageBox.Show(" Se ha pagado la nómina del conserje por $1,500 ");
        }

        public override void trabajo()
        {
            MessageBox.Show(" El conseje esta lavando los baños ");
        }

        public override void ficha_empleado(string N, int N_T, string RFC_)
        {
            MessageBox.Show(" Ficha del empleado ");
            nombre = N;
            Num_trabajador = N_T;
            RFC = RFC_;
        }
    }
}
