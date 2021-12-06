using System;
using System.Collections.Generic;
using System.Text;

namespace ARREGLOS_UNIDIMENSIONALES
{
    class _4
    {

        static void Main(string[] args)
        {
			/*Almacenar 8 números en un vector, almacenarlos en otro vector en orden inverso al vector original
              e imprimir el vector resultante.*/
			int X;
			Console.WriteLine("Ingrese la cantidad de posición de vector ");
			bool resp = int.TryParse(Console.ReadLine(), out X);
			int[] vector1;
			vector1 = new int[X];
			int[] vector2;
			vector2 = new int[X];
			for (int inverso = 0; inverso < vector1.Length; inverso++)
			{
				Console.WriteLine("Ingrese un número " + inverso);
				vector1[inverso] = int.Parse(Console.ReadLine());
			}
			for (int inverso = 0; inverso < vector2.Length; inverso++)
			{
				vector2[inverso] = vector1.Length - inverso;
				Console.WriteLine("Solución invertido " + vector2[inverso]);
			}
		}
    }
}
