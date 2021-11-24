using System;
using System.Collections.Generic;
using System.Text;

namespace DOWHILE
{
    class DOWHILE3
    {

        static void Main(string[] args)
        {

			/*En la Cámara de Diputados se levanta una encuesta con todos los integrantes con el fin de determinar
               que porcentaje de los n diputados esta a favor del Tratado de Libre Comercio, que porcentaje esta en
            contra y que porcentaje se abstiene de opinar.
             El programa debe preguntar si se desea continuar ingresando datos.*/
			string respuesta;
			int voto, canFav = 0, canCont = 0, canAbs = 0, totalDiputados = 0;
			double porcFav, porCont, porcAbs;

			do
			{
				Console.WriteLine("Esta a favor del tratado de libre comercio? A favor(1) En contra(2) Se abstiene(3)");
				bool resp = int.TryParse(Console.ReadLine(), out voto);

				switch (voto)
				{
					case 1:
						canFav++;
						break;
					case 2:
						canCont++;
						break;
					case 3:
						canAbs++;
						break;
					default:
						Console.WriteLine("Numero incorrecto");
						break;
				}
				Console.WriteLine("Hay mas diputados para ingresar a la encuesta? (si) (no)");
				respuesta = Console.ReadLine();

				// totalDiputados++;

			} while (respuesta == "si");

			totalDiputados = canFav + canCont + canAbs;
			porcFav = canFav * 100 / totalDiputados;
			porCont = canCont * 100 / totalDiputados;
			porcAbs = canAbs * 100 / totalDiputados;

			Console.WriteLine("El porcentaje a favor es de: " + porcFav);
			Console.WriteLine("El porcentaje en contra es de: " + porCont);
			Console.WriteLine("El porcentaje que se abstiene es de: " + porcAbs);



		}
    }
}
