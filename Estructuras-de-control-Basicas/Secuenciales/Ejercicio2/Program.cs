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

            // Entrada datos
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            // Proceso
            int suma = num1 + num2;

            // Salida
            Console.WriteLine("La suma es: " + suma);





            Console.ReadKey();
        }
    }
}
