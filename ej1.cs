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
			if (numero == "1")
			{
				output = "UNO";
			}
			else if (numero == "2")
			{
				output = "DOS";
			}
			else if (numero == "3")
			{
				output = "TRES";
			}
			else if (numero == "4")
			{
				output = "CUATRO";
			}
			else if (numero == "5")
			{
				output = "CINCO";
			}
			else if (numero == "6")
			{
				output = "SEIS";
			}
			else if (numero == "7")
			{
				output = "SIETE";
			}
			else if (numero == "8")
			{
				output = "OCHO";
			}
			else if (numero == "9")
			{
				output = "NUEVE";
			}
			else
			{
				output = "OTROS";
			}			
			Console.WriteLine(output);
		}
	}	
}
					
