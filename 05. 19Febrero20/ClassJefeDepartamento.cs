using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Febrero20
{
    public class ClassJefeDepartamento : Empleado
    {
        public override void pagar_nomina()
        {
            MessageBox.Show(" Se ha pagado la nómina del jefe de departamento por $8,600 ");
        }

        public override void trabajo()
        {
            MessageBox.Show(" El jefe de departamento se encuentra en una junta ");
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
