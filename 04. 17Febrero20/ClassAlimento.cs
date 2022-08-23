using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Febrero20
{
    class Alimento
    {
        float azúcar, g_secreto;
        public string nombre;
        public string ingr_secreto;
        public float sal;
        
        public Alimento()
        {
        
        }

        public void Sal_receta(float SAL)
        {
            sal = SAL;
        }

        public float Sal_alimento()
        {
            return sal;
        }

        public float G_SECRETO
        {
            get { return g_secreto; }
            set { g_secreto = value; }
        }
        public float AZÚCAR
        {
            get { return azúcar; }
            set { azúcar = value; }
        }
    }
}
