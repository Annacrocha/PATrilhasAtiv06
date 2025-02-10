using System;

namespace lista06
{
    class Program
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) 
                {
                    soma += i; 
                }
            }

            Console.WriteLine($"A soma dos números pares entre 1 e 100 é: {soma}");
          
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
