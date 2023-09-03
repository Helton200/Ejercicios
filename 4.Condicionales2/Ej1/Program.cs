using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.

            int N1, N2,resultado;

            Console.WriteLine("Ingrese el Primer Numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero: ");
            N2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El calulo a realizar es: ");

            if(N1>N2){
                resultado = N1 - N2;
                Console.WriteLine("Resta");
            } else if( N1==N2){
                resultado = N1 + N2;
                Console.WriteLine("Suma");
            } else{
                resultado = N1 * N2;
                Console.WriteLine("Multiplicación");
            }
            Console.WriteLine($"El resultado del calculo es: {resultado}");
        }
    }
}
