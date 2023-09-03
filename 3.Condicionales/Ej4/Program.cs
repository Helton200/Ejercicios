using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int N1, N2, N3, N4;

            Console.WriteLine("Ingrese el Primer Numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Tercer Numero: ");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Cuarto Numero: ");
            N4 = int.Parse(Console.ReadLine());

            if (N1 < N2 && N1 < N3 && N1 < N4){
                Console.WriteLine($"{N1} Es el numero mas pequeño");
            }
            else if (N2 < N1 && N2 < N3 && N2 < N4){
                Console.WriteLine($"{N2} Es el numero mas pequeño");
            } else if (N3 < N2 && N3 < N1 && N3 < N4){
                Console.WriteLine($"{N3} Es el numero mas pequeño");
            } else {
                 Console.WriteLine($"{N4} Es el numero mas pequeño");
            }
        }
    }
}
