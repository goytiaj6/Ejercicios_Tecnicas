using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Marzo20
{
    class Factura:IPorPagar
    {
        public string NumeroPieza;
        public string DescripciónPieza;
        public int Cantidad;
        public decimal PrecioPorArticulo;
        public decimal Total;


        //Constructor de cuatro parámetros
        public Factura(string numPieza, string descPieza, int cant, decimal precio)
        {
            NumeroPieza = numPieza;
            DescripciónPieza = descPieza;
            Cantidad = cant;
            PrecioPorArticulo = precio;
        }

        public override string ToString()
        {
            return NumeroPieza + " | " + DescripciónPieza + " | " + Cantidad + " | " + "$" + Convert.ToString(Total);
        }

        public decimal ObtenerMontoPago()
        {
            Total = Cantidad * PrecioPorArticulo;
            return Total;
        }
    }
}
