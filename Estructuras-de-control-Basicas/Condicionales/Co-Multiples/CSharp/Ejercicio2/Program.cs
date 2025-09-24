using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elija una opción [1-4]: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("has elegido sumar. "); break;
                case 2:
                    Console.WriteLine("has elegido restar. "); break;
                case 3:
                    Console.WriteLine("has elegido multiplicar. "); break;
                case 4:
                    Console.WriteLine("has elegido dividir. "); break;
                default:
                    Console.WriteLine("Opción no válida"); break;
            }



            Console.ReadKey();













        }
    }
}
