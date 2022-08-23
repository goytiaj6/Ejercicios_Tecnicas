using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Febrero20
{
    public class ClassResponsableLab : Empleado
    {
        public override void pagar_nomina()
        {
            MessageBox.Show(" Se ha pagado la nómina del responsale de laboratorio por $2,500 ");
        }

        public override void trabajo()
        {
            MessageBox.Show(" El responsable de laboratorio esta reparando las herramientas en mal estado ");
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
