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

            Console.Write("coloca tu calificacion: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 12)
            {
                Console.WriteLine("El estudiante aprobó.");
            }




        }
    }
}
