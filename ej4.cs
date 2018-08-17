using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			const int limInf = 1;
			const int limSup = 100;
			int sum = 0;
			const int cantidad = limSup - limInf + 1;
			int i = limInf;
			while (i <= limSup)
			{
				sum += i;
				i++
			}
			double promedio = sum/(cantidad*1.0);
			Console.WriteLine("La suma de los numeros del {1} al {2} es {0}", sum, limInf, limSup);
			Console.WriteLine("El promedio es {0:0.00}", promedio);
		}
	}
}