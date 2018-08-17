using System;

namespace TrabajoPractico1
{
	public class Program
	{
		private static bool EsPrimo(int num)
		{
			for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(num)); i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}
		public static void Main()
		{
			const int limInf = 35;
			const int limSup = 1977;
			int sum = 0;
			for (int i = limInf; i <= limSup; i++)
			{
				if (EsPrimo(i))
				{
					sum += i;
				}
			}
			Console.WriteLine("La suma de los numeros primos entre {0} y {1} es {2}", limInf, limSup, sum);
 		}
	}
}