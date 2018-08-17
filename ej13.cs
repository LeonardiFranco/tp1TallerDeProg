using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static String Invertir(String cadena)
		{
			int longitud = cadena.Length;
			String nuevaCadena = "";
			for (int i = longitud - 1; i >= 0; i--)
			{
				nuevaCadena += cadena[i];
			}
			return nuevaCadena;
		}

		public static void Ordenar(String[] cadenas)
		{
			int longitud = cadenas.Length;
			QuickSort(cadenas, 0, longitud - 1);
		}

		// Implementacion del algoritmo QuickSort
		public static void QuickSort(String[] arr, int lo, int hi)
		{
			if (lo < hi)
			{
				int p = Partition(arr, lo, hi);
				QuickSort(arr, lo, p);
				QuickSort(arr, p + 1, hi);
			}
		}

		public static int Partition(String[] arr, int lo, int hi)
		{   //DESCENDENTE
			String pivot = arr[lo];
			int i = lo - 1;
			int j = hi + 1;
			while (true)
			{
				do {
					i++;
				} while (arr[i].CompareTo(pivot) > 0);
				do {
					j--;
				} while (arr[j].CompareTo(pivot) < 0);
				if (i >= j) 
				{
					return j;
				}
				String temp = arr[j];
				arr[j] = arr[i];
				arr[i] = temp;
			}
			
		}

		public static void Main(String[] args)
		{
			const int cadenas = 5;
			if (args.Length == cadenas)
			{
				for (int i = 0; i < cadenas; i++)
				{
					args[i] = Invertir(args[i]);
				}
				Ordenar(args);
				for (int i = 0; i < cadenas; i++)
				{
					Console.WriteLine(args[i]);
				}

			}
		}
	}
}