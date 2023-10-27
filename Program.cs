using System.Diagnostics.CodeAnalysis;

namespace Examen_OAEA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalxProducto;
            int TotaxVendedor;
            int suma;


            Console.WriteLine("Se muestra una tabla con los productos");



            int[,] productos = new int[5, 4]
            {
                {500, 3000, 100, 400 },
                {1000, 150, 200, 500 },
                {250, 1800, 2900, 300 },
                {400, 130, 90, 2400 },
                {60, 20, 4000, 3600 }

            };
            for(int i = 0; i < productos.GetLength(1); i++) 
            {


                //suma = TotalxProducto = productos[i];



                for (int j = 0; j < productos.GetLength(1); j++)
                {
                    Console.WriteLine(productos[i, j] );

                    suma = TotaxVendedor = productos[i, j] / 2;

                    Console.WriteLine(" El total del vendedor es: " +  suma);

                   
                }



            }
            
        }
    }
}

/*Dada la siguiente tabla de productos por vendedores, cree un programa que utilice
 * un arreglo bidimensional para calcular la ganancia de la venta por producto y
 * la ganancia generada por cada vendedor.

Tabla

Incisos:

Imprima la tabla en consola.
Imprima la ganancia total generada por cada  vendedor. 
     Ejemplo: "El vendedor 1 tuvo una ganancia de 86 pesos".
Imprima la ganancia total generada por cada producto. 
     Ejemplo: "El producto 1 genero 1000 pesos de ganancia."*/