using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			int sum = 0;
			const int cantidad = 50;
			for (int i = 1; i < 100; i += 2)
			{
				sum += i;
			}
			double promedio = sum/(cantidad*1.0);
			Console.WriteLine("La suma de los numeros impares del {1} al {2} es {0}", sum, 1, 100);
			Console.WriteLine("El promedio es {0:0.00}", promedio);
		}
	}
}