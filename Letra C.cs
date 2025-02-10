using System;

namespace lista06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira uma palavra:\n ");
            string palavra = Console.ReadLine();

            Console.WriteLine("As letras da palavra são:\n");

            foreach (char letra in palavra)
            {
                Console.WriteLine(letra);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
