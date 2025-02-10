using System;

namespace lista06
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número inteiro positivo:\n");
			int n = int.Parse(Console.ReadLine());
			
			int soma = 0;
			
			Console.WriteLine("\n");
			
			for (int i = 1; i <= n; i++) {
				soma += i;
			}
			
			 Console.WriteLine("A soma de todos os números entre 1 e " + n +  " é: " + soma);
			                  
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
