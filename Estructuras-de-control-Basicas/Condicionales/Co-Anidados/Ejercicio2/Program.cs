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
            
            string usuario = "admin";
            string contraseña = "1234";
            Console.WriteLine("coloque su usuario: ");
            usuario = Console.ReadLine();
            

            if (usuario == "admin")
            {
                Console.WriteLine("coloque su contraseña: ");
                contraseña = Console.ReadLine();
                if (contraseña == "1234")
                {
                    Console.WriteLine("Acceso permitido.");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }
            }
            else
            {
                Console.WriteLine("Usuario no válido.");
            }



            Console.ReadKey();  

        }
    }
}
