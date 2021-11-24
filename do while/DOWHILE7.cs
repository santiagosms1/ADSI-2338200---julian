using System;
using System.Collections.Generic;
using System.Text;

namespace DOWHILE
{
    class DOWHILE7
    {

        static void Main(string[] args)
        {
			/*Hacer un programa que lea caracteres desde teclado hasta que lea 10 veces la letra 'a'. Por cada
           carácter leído que no sea una 'a' debe mostrar un mensaje indicándolo. Cuando lea las 10 letras 'a'
               el programa terminará.*/

			String letra, cadena;
			int CantL = 0, i = 1;

			do
			{
				Console.WriteLine("Ingrese una letra");
				cadena = Console.ReadLine();
				letra = cadena.ToLower();

				if (letra == "a")
				{
					CantL++; // CantL = CantL + 1;

					Console.WriteLine("La letra ingresada fue: " + cadena);
					Console.WriteLine("la cantidad de letras de (A) hasta el momento es: " + CantL);
				}
				else
				{
					Console.WriteLine("La letra ingresada fue: " + cadena);
				}

				i++;
			} while (CantL <= 10);

		}
	}
}
