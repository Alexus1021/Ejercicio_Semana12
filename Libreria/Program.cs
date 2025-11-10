using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana12_FA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librería libreria = new Librería();
            int opcion;

            do
            {
                Console.WriteLine("\n========= MENÚ PRINCIPAL =========");
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Mostrar libros");
                Console.WriteLine("3. Modificar libro");
                Console.WriteLine("4. Eliminar libro");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        libreria.Registrar();
                        break;
                    case 2:
                        libreria.Mostrar();
                        break;
                    case 3:
                        libreria.Modificar();
                        break;
                    case 4:
                        libreria.Eliminar();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
