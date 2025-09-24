using System;

class Program
{
    static void Main()
    {
        string clave = "";
        
        while (clave != "1234")
        {
            Console.Write("Ingresa la clave: ");
            clave = Console.ReadLine();
        }

        Console.WriteLine("Acceso permitido");
    }
}
