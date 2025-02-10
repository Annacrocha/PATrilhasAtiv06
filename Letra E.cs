using System;

namespace lista06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine(numero + " não é um número primo.");
            } else {
                bool primo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine(numero + " é um número primo.");
                }
                else
                {
                    Console.WriteLine(numero + " não é um número primo.");
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
