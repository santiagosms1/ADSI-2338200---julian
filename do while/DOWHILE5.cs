using System;
using System.Collections.Generic;
using System.Text;

namespace DOWHILE
{
    class DOWHILE5
    {


        static void Main(string[] args)
        {

            /*Calcular la suma siguiente:
             100 + 98 + 96 + 94 + . . . + 0 en este orden*/

            int suma = 0, i = 100;

            do
            {
                suma += i;
                i -= 2;
            } while (i >= 0);

            Console.WriteLine("la suma es: " + suma);
        }
    }
}
