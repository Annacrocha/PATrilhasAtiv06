using System;

namespace lista06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 0) {
               Console.WriteLine("Por favor, insira um número inteiro positivo.");
            } else {
                Console.WriteLine($"Divisores de {numero}:");
                for (int i = 1; i <= numero; i++) {
                    if (numero % i == 0) {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
