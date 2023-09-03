using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero. */

            int N1, N2, N3;
            
            int producto;

            Console.WriteLine("Ingrese el Primer Numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Tercer Numero: ");
            N3 = int.Parse(Console.ReadLine());

            int sum= N1+N2;
            producto = N2 * N3;

            if(sum>producto){
                Console.WriteLine($"La suma entre {N1}, y {N2} da un total de {sum}. Lo cual supera al Producto entre {N2}, y {N3} con un resultado de {producto}");
            } else {
                Console.WriteLine($"La suma entre el primer numero y el segundo, no supera el producto entre {N2}, y {N3}");
            }

        }
    }
}
