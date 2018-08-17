using System;
using System.Linq;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			Random rnd = new Random();
			const int valMin = 0;
			const int valMax = 1000;
			const int rango = valMax - valMin;
			double[] arreglo = new double [30];
			double sum = 0;
			// Llenando el arreglo
			for (int i = 0; i < 30; i++)
			{
				double numeroAleatorio = rnd.NextDouble() * rango + valMin;
				arreglo[i] = numeroAleatorio;
				sum += numeroAleatorio;
			}
			double min = arreglo.Min();
			double max = arreglo.Max();
			double promedio = sum/30.0;
			Console.WriteLine("El min. es {0}, el max. es {1}, la suma es {2} y su promedio es {3}", min, max, sum, promedio);
		}
	}
}