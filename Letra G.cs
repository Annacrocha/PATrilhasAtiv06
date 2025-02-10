using System;

namespace lista06
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numero = 5; 

            Console.WriteLine($"Tabuada do {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
