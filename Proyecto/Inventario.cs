using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Proyecto
{
    public class Inventario : IngresarProducto
    {
        private int noProducto;

        //private int NoProducto { get { return noProducto; } set { noProducto = value; }}
        private int NoProd { get; set; }

        //Metodo para revisar el inventario por numero: Aplicando Unidad 2
        public void RevisarInventarioPorNumero(Inventario revisionInventario)
        {
            StreamReader lectura;
            string linea;
            string numeroproducto;
            bool encontrado;
            encontrado = false;
            string[] espacio = new string[5];
            char[] separador = { '-' };

            try
            {
                lectura = File.OpenText("Inventario.txt");
                Console.WriteLine("Ingrese el numero del producto que gustas revisar: ");
                numeroproducto = Console.ReadLine();
                linea = lectura.ReadLine();

                Inventario productoInventario = new Inventario();//Instanciacion: Aplicando Unidad 2 (Objeto)

                while (linea != null && encontrado == false)
                {
                    espacio = linea.Split(separador);
                    if (espacio[0].Trim().Equals(numeroproducto))
                    {
                        productoInventario.NoProducto = Convert.ToInt32(espacio[0].Trim());
                        productoInventario.NombreProducto = espacio[1].Trim();
                        productoInventario.FechaCaducidad = Convert.ToDateTime(espacio[2].Trim());
                        productoInventario.Cantidad = Convert.ToDouble(espacio[3].Trim());
                        productoInventario.Precio = Convert.ToDouble(espacio[4].Trim());
                        productoInventario.Total = Convert.ToDouble(espacio[5].Trim());

                        ImprimirInventario(productoInventario);
                        encontrado = true;
                    }
                    else
                    {
                        linea = lectura.ReadLine();
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine("El numero del  producto del inventario " + numeroproducto + " no existe");
                }
                lectura.Close();
            
            }
            catch (FileNotFoundException error)//Muestra el error por default cuando no encuentra el archivo de inventario: Aplicando Unidad 5
            {
                Console.WriteLine("Error" + error.Message);
            }
            Console.ReadKey();
        }

        public void RevisarInventarioPorNumeroExportado(Inventario revisionInventario)
        {
            StreamReader lectura;
            string linea;
            string numeroproducto;
            bool encontrado;
            encontrado = false;
            string[] espacio = new string[5];
            char[] separador = { '-' };

            try
            {
                lectura = File.OpenText("Exportar.txt");
                Console.WriteLine("Ingrese el numero del producto que gustas revisar: ");
                numeroproducto = Console.ReadLine();
                linea = lectura.ReadLine();

                Inventario productoInventario = new Inventario();//Instanciacion: Aplicando Unidad 2

                while (linea != null && encontrado == false)
                {
                    espacio = linea.Split(separador);
                    if (espacio[0].Trim().Equals(numeroproducto))
                    {
                        productoInventario.NoProducto = Convert.ToInt32(espacio[0].Trim());
                        productoInventario.NombreProducto = espacio[1].Trim();
                        productoInventario.FechaCaducidad = Convert.ToDateTime(espacio[2].Trim());
                        productoInventario.Cantidad = Convert.ToDouble(espacio[3].Trim());
                        productoInventario.Precio = Convert.ToDouble(espacio[4].Trim());
                        productoInventario.Total = Convert.ToDouble(espacio[5].Trim());

                        ImprimirInventario(productoInventario);
                        encontrado = true;
                    }
                    else
                    {
                        linea = lectura.ReadLine();
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine("El numero del  producto del inventario " + numeroproducto + " no existe");
                }
                lectura.Close();

            }
            catch (FileNotFoundException error)//Muestra el error por default cuando no encuentra el archivo de inventario: Aplicando Unidad 5
            {
                Console.WriteLine("Error" + error.Message);
            }
            Console.ReadKey();
        }

        private void ImprimirInventario(Inventario productoInventario)
        {
            Console.WriteLine("Numero del productio: " + productoInventario.NoProducto);
            Console.WriteLine("Nombre del producto: " + productoInventario.NombreProducto);
            Console.WriteLine("Fecha de caducidad: " + productoInventario.FechaCaducidad);
            Console.WriteLine("Cantidad de productos: " + productoInventario.Cantidad);
            Console.WriteLine("Precio del producto: " + productoInventario.Precio);
            Console.WriteLine("Total: " + productoInventario.Total);
        }

        public void ExportarProducto(Inventario exportacionInventario)
        {
            StreamReader lectura;
            StreamWriter temporal;
            string linea;
            string numeroProducto;
            bool encontrado;
            encontrado = false;
            string[] espacio = new string[4];
            char[] separador = { '-' };

                try
                {
                    lectura = File.OpenText("Inventario.txt");
                    temporal = File.CreateText("Backup.txt");
                    Console.WriteLine("Ingrese el numero del producto que gustes exportar a otra sucursal: ");
                        
                    numeroProducto = Console.ReadLine();
                    linea = lectura.ReadLine();

                    while (linea != null)
                    {
                        espacio = linea.Split(separador);
                        if (espacio[0].Trim().Equals(numeroProducto))
                        {
                            encontrado = true;
                        }
                        else
                        {
                            temporal.WriteLine(linea); //Se sobreescribira las lineas de texto indiferentes a otro documento haciendo este el principal
                        }
                        linea = lectura.ReadLine();
                    }
                    if (encontrado == false)
                    {
                        Console.WriteLine("El numero del  producto del inventario " + numeroProducto + " no existe");
                    }
                    else
                    {
                        Console.WriteLine("El producto ha sido exportado a otra sucursal...");
                    }
                    lectura.Close();
                    temporal.Close();
                    //En esto se elimina el documento principal y se renombra
                    //Cambia el documento backup por el de inventario

                    File.Move("Backup.txt", "Exportar.txt");
                    
                }
                catch (FileNotFoundException error)
                {
                    Console.WriteLine("Error" + error.Message);
                }
                Console.ReadKey();
                
        }
    }
}
