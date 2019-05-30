using System;

namespace Proyecto
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Menu
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("1.- Ingresar producto " +
                "\n2.- Revisar Inventario por numero" +
                "\n3.- Exportar Producto" +
                "\n4.- Revisar Inventario por numero Exportados" +
                "\n5.- Salir...");
                Console.WriteLine("Ingresa la opcion que deseas realizar: ");
                opcion = int.Parse(Console.ReadLine());

                //instansaciones para llamar metodos (Unidad 2)
                Producto ingresoProductoAlmacen = new IngresarProducto();
                Inventario revisionInventario = new Inventario();
                Inventario exportacionProducto = new Inventario();

                switch (opcion)
                {
                    case 1: //Ingresar producto
                        Console.Clear();
                        ingresoProductoAlmacen.IngresarProductoInventario(ingresoProductoAlmacen); //Llamado de metodo (unidad 2)
                        Console.ReadKey();
                        break;
                    case 2: //Revisar inventario
                        Console.Clear();
                        revisionInventario.RevisarInventarioPorNumero(revisionInventario);//Llamado de metodo (unidad 2)
                        Console.ReadKey();
                        break;
                    case 3://Exportar Producto
                        Console.Clear();
                        exportacionProducto.ExportarProducto(exportacionProducto);//Llamado de metodo (unidad 2)
                        Console.ReadKey();
                        break;
                    case 4://Revisar el invantario de los productos exportados
                        Console.Clear();
                        revisionInventario.RevisarInventarioPorNumeroExportado(revisionInventario);//Aplicacion de sobrecarga de metodo (unidad 2)
                        Console.ReadKey();
                        break;
                    case 5://Cerrar Programa
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion invalida...");
                        Console.WriteLine("Presione ''Enter'' para continuar");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 4);
            
            Console.ReadKey();
        }
    }
}
