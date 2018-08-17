using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			ulong n1 = 0;
			ulong n2 = 1;
			ulong n3;
			Console.WriteLine("Termino 0: 0");
			for (int i = 1; i <= 50; i ++)
			{
				n3 = n2 + n1;
				n1 = n2;
				n2 = n3;
				Console.WriteLine("Termino {0}: {1}", i, n1);
			}
		}
	}
}