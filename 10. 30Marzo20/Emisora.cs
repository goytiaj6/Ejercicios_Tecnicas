using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Marzo20
{
    public delegate void MiDelegado(string T);
    
    public class Emisora
    {
        public event MiDelegado MiEvento;

        public void LanzarEvento()
        {
            MiEvento("Lancé un evento");
        }
    }
}
