using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_U6
{
    class Program
    {
        public class Amazon
        {
            string NombreP, DescripcionP;
            float PrecioP;
            int StockP;

            public void CreacionArchivo()
            {
                StreamWriter sw = new StreamWriter("Productos.txt", true);

                Console.Write("Nombre del Producto: ");
                NombreP = Console.ReadLine();
                Console.Write("Descripcion del Producto: ");
                DescripcionP = Console.ReadLine();
                Console.Write("Precio del producto: ");
                PrecioP = float.Parse(Console.ReadLine());
                Console.Write("Cantidad en stock del producto: ");
                StockP = int.Parse(Console.ReadLine());

                //Escribe los datos del archivo          
                sw.WriteLine(NombreP + " " + DescripcionP + " " + PrecioP + " " + StockP );
         
                Console.WriteLine("Escribiendo en el archivo...");
                sw.Close();
                Console.ReadKey();
            }

            //Metodo para Leer el Archivo
            public void LecturaArchivo()
            {
                StreamReader sr = new StreamReader("Productos.txt");     
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                int Opcion;

                //Creacion de objeto
                Amazon Datos = new Amazon();
                try
                {
                    do
                    {
                        //Menu de Opciones
                        Console.Clear();
                        Console.WriteLine("MENU DE OPCIONES");
                        Console.WriteLine("1-Agregar un producto al archivo");
                        Console.WriteLine("2-Leer los productos del archivo");
                        Console.WriteLine("3-Salir del programa");
                        Console.Write("Escoja una opcion: ");
                        Opcion = int.Parse(Console.ReadLine());

                        switch (Opcion)
                        {
                            case 1:

                                Datos.CreacionArchivo();

                                break;

                            case 2:
                                Datos.LecturaArchivo();

                                break;
                            case 3:
                                Console.Write("\nPresione ENTER para salir del programa.");
                                Console.ReadKey();
                                break;

                            default:
                                Console.Write("\nOpcion incorrecta, ingrese una valida: ");
                                Console.ReadKey();
                                break;

                        }
                    } while (Opcion != 3);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}
