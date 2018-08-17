using System;

namespace TrabajoPractico1
{
	public class Program
	{
		private static bool EsBisiesto(int anio)
		{
			return (anio % 4 == 0) && ((anio % 400 == 0) || !(anio % 100 == 0));
		}
		public static void Main()
		{
			const int limInf = 1900;
			const int limSup = 2015;
			Console.WriteLine("Años bisiestos entre {0} y {1}.", limInf, limSup);
			for (int i = limInf; i < limSup; i++)
			{
				if (EsBisiesto(i))
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}