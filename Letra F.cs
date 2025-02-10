using System;

namespace lista06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantos números você deseja inserir? ");
            int quantidade = int.Parse(Console.ReadLine());

            int maiorNumero = int.MinValue;

            for (int i = 11; i < quantidade; i++)
            {
                Console.Write("Insira o número " + i + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maiorNumero) 
                {
                    maiorNumero = numero;
                }
            }

            Console.WriteLine("O maior número inserido foi: " + maiorNumero);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
