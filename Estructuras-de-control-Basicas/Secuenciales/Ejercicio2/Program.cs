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
            // Entrada datos
            Console.Write("Ingrese la base del triángulo: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            double h = double.Parse(Console.ReadLine());

            // Proceso
            double area = (b * h) / 2;

            // Salida
            Console.WriteLine("El área del triángulo es: " + area);









            Console.ReadKey();
        }
    }
}
