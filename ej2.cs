using System;

namespace TrabajoPractico1
{
	public class Program
	{
		public static void Main()
		{
			String output;
			Console.WriteLine("Ingrese un numero");
			String numero = Console.ReadLine();
			switch(numero)
			{
				case "1":
					output = "UNO";
					break;
				case "2":
					output = "DOS";
					break;
				case "3":
					output = "TRES";
					break;
				case "4":
					output = "CUATRO";
					break;
				case "5":
					output = "CINCO";
					break;
				case "6":
					output = "SEIS";
					break;
				case "7":
					output = "SIETE";
					break;
				case "8":
					output = "OCHO";
					break;
				case "9":
					output = "NUEVE";
					break;
				default:
					output = "OTROS";
					break;
			}
			Console.WriteLine(output);
		}
	}	
}