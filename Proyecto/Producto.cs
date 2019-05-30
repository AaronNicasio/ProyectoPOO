using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    //Clase Abstracta: Aplicando Unidad 3
    public abstract class Producto
    {
        private int noProducto;
        private string nombreProducto;
        private DateTime fechaCaducidad;
        private double precio;
        private double cantidad;
        private double total;

        //Encapsulamiento: Aplicando Unidad 2
        public int NoProducto
        {
            get { return noProducto; }
            set { noProducto = value; }
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public DateTime FechaCaducidad
        {
            get { return fechaCaducidad; }
            set { fechaCaducidad = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public abstract void IngresarProductoInventario(Producto producto);
    }
}
