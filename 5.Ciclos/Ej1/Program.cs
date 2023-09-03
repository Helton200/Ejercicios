using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

            int cont = 0;
            for (int i = 1; i <= 10; i++)
            {
                cont++;
                Console.WriteLine($"{cont}");
            }
        }
    }
}
