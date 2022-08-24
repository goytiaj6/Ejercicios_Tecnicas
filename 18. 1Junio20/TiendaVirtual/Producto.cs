using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVirtual
{
    public class Producto
    {
        public string nombre;
        public int ID;
        public int precio;

        //Constructores
        public Producto()
        {

        }

        public Producto(string N, int id, int prcio)
        {
            nombre = N;
            ID = id;
            precio = prcio;
        }

        public static List<Producto> Compras = new List<Producto>();

        public void agregarCarrito(Producto prod)
        {
            Compras.Add(prod);
        }

        public void mostrar()
        {

            int i;
            string s = "";
            int total = 0;

            if (Compras.Count == 0)
            {
                MessageBox.Show(" Carrito de compras vacío");
            }

            else
            {

                for (i = 0; i <= Compras.Count - 1; i++)
                {
                    s = s + "Nombre: " + Compras[i].nombre + "   ID: " + Convert.ToString(Compras[i].ID) + "\n";
                    total = total + Compras[i].precio;
                }

                MessageBox.Show(s + "\nTotal: $" + Convert.ToString(total) + " MXN");
            }
        }


        public string mostrar2()
        {

            int i;
            string s = "";
            int total = 0;

            if (Compras.Count == 0)
            {
                return ("Carrito de compras vacío");
            }

            else
            {

                for (i = 0; i <= Compras.Count - 1; i++)
                {
                    s = s + Convert.ToString(i+1) + " Nombre: " + Compras[i].nombre + "   ID: " + Convert.ToString(Compras[i].ID) + Environment.NewLine;
                    total = total + Compras[i].precio;
                }

                return (s + Environment.NewLine + "Total: $" + Convert.ToString(total) + " MXN");
            }
        }

        public void Borrar(int n)
        {
            Compras.RemoveAt(n-1);
        }
    }
}
