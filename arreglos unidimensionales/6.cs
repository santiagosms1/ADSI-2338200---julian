using System;
using System.Collections.Generic;
using System.Text;

namespace ARREGLOS_UNIDIMENSIONALES
{
    class _6
    {
        static void Main(string[] args)
        {
            /*Diseñe un algoritmo que lea dos vectores A y B de 7 elementos cada uno y multiplique el primer
            elemento de A con el último elemento de B y luego el segundo elemento de A por el sexto elemento
          de B y así sucesivamente hasta llegar al séptimo elemento de A por el primer elemento de B. El
            resultado de la multiplicación almacenarlo en un vector C. Mostrar el resultado.*/
            int[] vectorA;
            vectorA = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] vectorB;
            vectorB = new int[7] { 7, 6, 5, 4, 3, 2, 1 };
            int[] vectorResultado;
            vectorResultado = new int[7];

            Array.Reverse(vectorB);

            for (int i = 0; i < vectorA.Length; i++)
            {
                vectorResultado[i] = vectorA[i] * vectorB[i];
            }
            Console.WriteLine("Lista resultante: ");
            for (int i = 0; i < vectorResultado.Length; i++)
            {
                Console.WriteLine("el " + vectorA[i] + " x " + vectorB[i] + " es igual a: " + vectorResultado[i]);
            }
        }
    }
}
