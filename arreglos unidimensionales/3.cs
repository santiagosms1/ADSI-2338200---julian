using System;
using System.Collections.Generic;
using System.Text;

namespace ARREGLOS_UNIDIMENSIONALES
{
    class _3
    {
        static void Main(string[] args)
        {
			/*Almacenar 15 números en un vector, imprimir cuantos son ceros, cuántos son negativos, cuantos
             positivos. Imprimir además la suma de los negativos, la suma de los ceros y la suma de los positivos.*/
			int positivos = 0, negativos = 0, ceros = 0, sumaspos = 0, sumasneg = 0, sumasceros = 0;
			int[] numero = new int[15];
			for (int i = 0; i < numero.Length; i++)
			{
				Console.WriteLine("Digite un numero " + (i + 1));
				bool resp = int.TryParse(Console.ReadLine(), out numero[i]);
				if (numero[i] < 0)
				{
					sumasneg = sumasneg + numero[i];  // sumasneg += numero[i];
					negativos = negativos + 1; // negativos++;
				}
				else if (numero[i] == 0)
				{
					sumasceros = sumasceros + numero[i]; // sumasceros += numero [i];
					ceros = ceros + 1; // ceros++;
				}
				else
				{
					sumaspos = sumaspos + numero[i]; //sumaspos += numero[i];
					positivos = positivos + 1; // positivos++;

				}

			}
			Console.Write("Total de negativos: " + negativos);
			Console.Write("Total de ceros: " + ceros);
			Console.Write("Total de positivos: " + positivos);

			Console.WriteLine("***********************");

			Console.WriteLine("Total de la suma de negativos: " + sumasneg);
			Console.WriteLine("Total de la suma de ceros: " + sumasceros);
			Console.WriteLine("Total de la suma de positivos: " + sumaspos);
		}
    }
}
