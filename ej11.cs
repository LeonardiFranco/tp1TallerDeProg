using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Ingrese un radio: ");
			double radio = Convert.ToDouble(Console.ReadLine());
			double area = Math.PI * Math.Pow(radio, 2);
			double perimetro = 2 * Math.PI * radio;
			Console.WriteLine("El area del circulo de radio {0} es {1:0.00} y su perimetro es {2:0.00}.", radio, area, perimetro);
 		}
	}
}