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

            
            Console.WriteLine("coloca el numero: ");
            int numero = int.Parse(Console.ReadLine());


            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }



            Console.ReadKey();  



        }
    }
}
