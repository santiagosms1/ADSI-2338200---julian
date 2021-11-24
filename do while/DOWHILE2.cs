using System;
using System.Collections.Generic;
using System.Text;

namespace DOWHILE
{
    class DOWHILE2
    {
        static void Main(string[] args)
        {
            /*Un alumno de la clase de lógica matemática desea desarrollar un algoritmo y diagrama de flujo en el
            cual introduzca un número entero positivo e invierta los dígitos del número. Mostrar el número
               invertido.*/
            int continuar, inverso, num, residuo;
            do
            {
                Console.WriteLine("Digite un numero entero positivo de dos o mas cifras para invertir");
                int.TryParse(Console.ReadLine(), out num);
                residuo = num % 10;
                inverso = num / 10;
                Console.WriteLine("el numero invertido es: " + residuo + inverso);
                Console.WriteLine("Digite (1) si quiere continuar, o (0) para finalizar");
                int.TryParse(Console.ReadLine(), out continuar);

            } while (continuar == 1);


        }
    }
}
