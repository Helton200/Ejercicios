using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

            int N1, N2, N3, N4;

            Console.WriteLine("Ingrese el Primer Numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Tercer Numero: ");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Cuarto Numero: ");
            N4 = int.Parse(Console.ReadLine());

            if(N1>N2 && N2>N3 && N3>N4)
            {
                Console.WriteLine("Los numeros ingresados se encuentran en ordenados de forma decreciente");
            } else
            {
                Console.WriteLine("Los numeros ingresados no se encuentran en ordenados de forma decreciente");
            }
        }
    }
}
