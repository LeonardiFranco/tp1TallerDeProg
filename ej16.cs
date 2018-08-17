using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Ingrese primera palabra: ");
			char[] pal1 = Console.ReadLine().ToLower().ToCharArray();
			Console.WriteLine("Ingrese segunda palabra: ");
			char[] pal2 = Console.ReadLine().ToLower().ToCharArray();
			int longitudPal1 = pal1.Length;
			int longitudPal2 = pal2.Length;
			bool res = true;
			if (longitudPal1 == longitudPal2)
			{
				Array.Sort(pal1);
				Array.Sort(pal2);
				for (int i = 0; i < longitudPal1; i++)
				{
					if (!(pal1[i] == pal2[i]))
					{
						res = false;
						break;
					}
				}
				Console.WriteLine(res);
			}
			else
			{
				res = false;
				Console.WriteLine(res);
			}
		}
	}
}