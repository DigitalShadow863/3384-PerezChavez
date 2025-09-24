using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Coloca tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad > 1)
            {
                if (edad < 12)
                {
                    Console.WriteLine("Es un niño.");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Es un adolescente.");
                }
                else
                {
                    Console.WriteLine("Es un adulto.");
                }
            }
            else
            {
                Console.WriteLine("es un bebe");
            }





            Console.ReadKey();

        }
    }
}
