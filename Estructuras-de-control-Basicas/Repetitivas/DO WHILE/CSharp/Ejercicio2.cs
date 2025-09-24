using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("----- MENÚ -----");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Despedirse");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) Console.WriteLine("¡Hola!");
            else if (opcion == 2) Console.WriteLine("¡Adiós!");
            
        } while (opcion != 3);

        Console.WriteLine("Programa finalizado.");
    }
}
