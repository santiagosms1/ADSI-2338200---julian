using System;
using System.Collections.Generic;
using System.Text;

namespace ARREGLOS_UNIDIMENSIONALES
{
    class _2
    {
        static void Main(string[] args)
        {
			/*Llenar dos vectores A y B de 10 elementos cada uno, sumar el elemento uno del vector A con el
           elemento uno del vector B y así sucesivamente hasta 10, almacenar el resultado en un vector C, e
            imprimir el vector resultante.*/
			int vector;
			Console.WriteLine("Digite la cantidad de posicion del vector");
			bool resp = int.TryParse(Console.ReadLine(), out vector);
			int[] A;
			A = new int[vector];
			int[] B;
			B = new int[vector];
			int[] C;
			C = new int[vector];
			for (int v = 0; v < A.Length; v++)
			{
				Console.WriteLine("Digite numero para vector A" + v);
				A[v] = int.Parse(Console.ReadLine());
			}
			for (int v = 0; v < B.Length; v++)
			{
				Console.WriteLine("Digite numero para vector B" + v);
				B[v] = int.Parse(Console.ReadLine());
			}
			for (int v = 0; v < C.Length; v++)
			{
				C[v] = A[v] + B[v];
				Console.WriteLine(A[v] + " + " + B[v] + " - " + C[v]);
			}
		}
    }
}
