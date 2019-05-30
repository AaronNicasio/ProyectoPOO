using System;
using System.Collections.Generic;
using System.Text;
using System.IO;//Pormite las funciones para crear un documento

namespace Proyecto
{
    //Clase Hija que hereda atributos de la clase Padre(Clase Abstracta)
    public class IngresarProducto : Producto
    {
        public override void IngresarProductoInventario(Producto producto)
        {
            StreamWriter Inventario = File.AppendText("Inventario.txt");

            Console.WriteLine("Ingrese el numero del Producto: ");
            NoProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del Producto: ");
            NombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de Caducidad(mm/dd/yy): ");
            FechaCaducidad = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de Productos: ");
            Cantidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del Producto: ");
            Precio = Convert.ToDouble(Console.ReadLine());

            Total = Cantidad * Precio;

            Inventario.WriteLine(NoProducto + " - " + NombreProducto + " - " + FechaCaducidad + " - " + Cantidad + " - " + Precio + " - " + Total);

            Inventario.Close();

            Console.ReadKey();
        }
    }
}