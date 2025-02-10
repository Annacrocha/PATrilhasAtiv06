using System;

namespace lista06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Números primos entre 1 e 100:");

            for (int numero = 2; numero <= 100; numero++) {
                bool ehPrimo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++) {
                    if (numero % i == 0) {
                        ehPrimo = false;
                        break;
                    }
                }

                if (ehPrimo) {
                    Console.WriteLine(numero);
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
