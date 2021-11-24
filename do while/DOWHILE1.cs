using System;
using System.Collections.Generic;
using System.Text;

namespace DOWHILE
{
    class DOWHILE1
    {

        static void Main(string[] args)
        {
			/*En un supermercado una ama de casa pone en su carrito los artículos que va tomando de los
             estantes. La señora quiere asegurarse de que el cajero le cobre bien lo que ella ha comprado, por lo
          que cada vez que toma un articulo anota su precio junto con la cantidad de artículos iguales que ha
           tomado y determina cuanto dinero gastara en ese articulo; a esto le suma lo que ira gastando en los
           demás artículos, hasta que decide que ya tomo todo lo que necesitaba. Ayúdale a esta señora a
             obtener el total de sus compras.*/

			int respuesta = 0, cantidad;
			double precio, total = 0, vArticulo;

			do
			{
				Console.WriteLine("Digite el valor del articulo");
				bool resp2 = double.TryParse(Console.ReadLine(), out vArticulo);
				Console.WriteLine("Digite la cantidad");
				bool resp3 = int.TryParse(Console.ReadLine(), out cantidad);
				precio = vArticulo * cantidad;
				Console.WriteLine("El subtotal de este articulo es: " + precio);
				total += precio;
				do
				{
					Console.WriteLine("¿Ya tiene todos los articulos? si(1) no(2)");
					bool resp = int.TryParse(Console.ReadLine(), out respuesta);

					if (respuesta != 1 && respuesta != 2)
					{
						Console.WriteLine("Respuesta incorrecta digite nuevamente");
					}

				} while (respuesta != 1 && respuesta != 2); // Se ejecuta mientras el usuario ingresa una respuesta incorrecta

			} while (respuesta != 1); // Mientras el usuario no tenga todos los articulos.
			Console.WriteLine("El total es de: " + total);

		}
    }
}
