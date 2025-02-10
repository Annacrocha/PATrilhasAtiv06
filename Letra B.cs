using System;

namespace lista06
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número inteiro positivo:\n");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("\n");
			for (int i = 0; i < n; i++) {
				if (i % 2 == 0) {
					Console.WriteLine(i);
				}
			}
			                  
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
