using System;

namespace TrabajoPractico1
{
	public class Program
	{
		private static double Termino(int nTermino){
			return Math.Pow(-1,nTermino)/(2*nTermino + 1.0);
		}
		public static void Main()
		{
			double sum = 0;
			Console.WriteLine("Ingrese termino final.");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i <= n; i++)
			{
				sum += Termino(i);
			}
			double pi = sum * 4;
			double error = Math.Abs((pi - Math.PI) / Math.PI)*100;
			Console.WriteLine("Calcule que pi es igual a {0:0.00000} con un error de {1:0.00000}%.", pi, error);
		}
	}
}