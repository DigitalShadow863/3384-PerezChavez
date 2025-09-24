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
            
            Console.Write("coloque su edad: ");
            int edad = int.Parse(Console.ReadLine());   

            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Es menor de edad.");
            }



            Console.ReadKey();
        }
    }
}
