using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeVentas
{
    class Ventas
    {
        private string _Producto;

        private int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }



        public string Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }

        //Asignacion de precio de los productos
        public double AsignarPrecio()
        {
            switch (Producto)
            {
                case "Teclado": return 35;
                case "Impresora": return 350;
                case "Monitor": return 550;
                case "Bocinas": return 50;
                case "Mouses": return 20;
            }
            return 0; 

        }

        //Calcular Subtotal
        public double CalcularSubtotal()
        {
            return AsignarPrecio() * Cantidad; 

        }

        //Calcular Descuento
        public double CalcularDescuento()
        {
            double subtotal = CalcularSubtotal();

            if (subtotal <= 300) return 5.0 / 100 * subtotal;
            else if (subtotal > 300 && subtotal <= 500) return 10.0 / 100 * subtotal;
            else return 12.5 / 100 * subtotal;

        }
        //Calcular Neto
        public double CalcularNeto()
        {
            return CalcularSubtotal() - CalcularDescuento();
        }

    }
}
