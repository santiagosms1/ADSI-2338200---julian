using System;

namespace Arrays_Excersice
{
    class Ejercicio01
    {
        static void MainTemporal(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* 1. Calcular el promedio de 50 valores almacenados en un vector. Determinar además cuantos son
            mayores que el promedio, imprimir el promedio, el número de datos mayores que el promedio y una
            lista de valores mayores que el promedio. */

            int cantNotas;
            double nota, suma = 0, promedio, notaAlta = 0, porcentaje = 0, NotasMayorProm = 0;
            int contPerdidas = 0;
            Console.WriteLine("Cuantos notas de estudiantes desea almacenar");
            _ = int.TryParse(Console.ReadLine(), out cantNotas);
            double[] vectorNotas = new double[cantNotas];

            // Ciclo para llenar las notas del vector
            for (int i = 0; i < vectorNotas.Length; i++)
            {
                Console.WriteLine("Digité la nota del estudiante " + (i + 1));
                _ = double.TryParse(Console.ReadLine(), out nota);
                suma += nota;
                vectorNotas[i] = nota;
            }

            promedio = suma / vectorNotas.Length;
            for (int i = 0; i < vectorNotas.Length; i++)
            {
                // Cuantos perdieron el examen
                if (vectorNotas[i] < 3)
                {
                    contPerdidas++;
                }
                //Nota mas alta
                if (vectorNotas[i] > notaAlta)
                {
                    notaAlta = vectorNotas[i];
                }
                porcentaje = ((contPerdidas - cantNotas) * 100) / cantNotas;
                if (vectorNotas[i] > promedio)
                {
                    NotasMayorProm++;
                }
            }
            Console.WriteLine("El promedio del grupo es: " + promedio);
            Console.WriteLine("La nota mas alta fue: " + notaAlta);
            Console.WriteLine(contPerdidas + " Perdieron la nota");
            Console.WriteLine("El porcentaje de personas que ganaron el examen fue: " + porcentaje + "%");
            Console.WriteLine("El número de almnos que superaron el promedio fueron: " + NotasMayorProm);
        }
    }
}