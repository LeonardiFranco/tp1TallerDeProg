using System;
using System.Linq;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Ordenar(int[] numeros)
		{
			int longitud = numeros.Length;
			QuickSort(numeros, 0, longitud - 1);
		}

		// Implementacion del algoritmo QuickSort
		public static void QuickSort(int[] arr, int lo, int hi)
		{
			if (lo < hi)
			{
				int p = Partition(arr, lo, hi);
				QuickSort(arr, lo, p);
				QuickSort(arr, p + 1, hi);
			}
		}

		public static int Partition(int[] arr, int lo, int hi)
		{	// ASCENDENTE
			int pivot = arr[lo];
			int i = lo - 1;
			int j = hi + 1;
			while (true)
			{
				do {
					i++;
				} while (arr[i].CompareTo(pivot) < 0);
				do {
					j--;
				} while (arr[j].CompareTo(pivot) > 0);
				if (i >= j) 
				{
					return j;
				}
				int temp = arr[j];
				arr[j] = arr[i];
				arr[i] = temp;
			}
			
		}
		public static void Main()
		{
			Random rnd = new Random();
			const int rango = 10000;
			const int limSup = 500;
			const int limInf = 20;
			int[] arreglo = new int [50];
			// Llenando el arreglo
			for (int i = 0; i < 50; i++)
			{
				int numeroAleatorio = rnd.Next(rango);
				arreglo[i] = numeroAleatorio;
			}
			Ordenar(arreglo);
			for (int i = 0; i < 50; i++)
			{
				if (arreglo[i] < limSup && arreglo[i] > limInf)
				{
					Console.WriteLine(arreglo[i]);
				}
			}
		}
	}
}