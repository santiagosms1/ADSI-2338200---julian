﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ARREGLOS_UNIDIMENSIONALES
{
    class _7
    {
        static void Main(string[] args)
        {
            /*Una agencia de seguros desea obtener un reporte al final del día de sus n empleados para determinar
           cuál fue el empleado que obtuvo el mayor sueldo en base a sus ventas y comisiones, se registrará el
            nombre del empleado la edad y el sueldo que obtuvo al final del día. Desarrollar un programa que
              pida al usuario el nombre de los n empleados, su edad y el sueldo para generar un reporte que lo
               muestre en pantalla de la siguiente manera: el nombre del empleado, edad, sueldo, el empleado con
                  mayor sueldo, el sueldo del empleado que gana más y su edad.
                      Debe declarar un arreglo de enteros para la edad.
                      Debe declarar un arreglo de reales para el sueldo.
                       Debe declarar un arreglo de cadena para el nombre*/
            string nombre;
            int edad, sueldo;
            bool result;
            int[] n = new int[15];

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Edad:");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Sueldo");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("****************");
            }
        }
    }
}
