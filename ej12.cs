using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Ingrese un numero natural para calcular su factorial: ");
			uint n = Convert.ToUInt32(Console.ReadLine());
			uint prod = 1;
			for (uint i = 1; i <= n; i++)
			{
				prod *= i;
			}
			Console.WriteLine("El factorial de {0} es {1}.", n, prod);
 		}
	}
}