using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            //Solicitar
            int n1;
            int resultado;

            Console
                .WriteLine("Este programa esta realizado para devolver numeros al cubo");

            Console.WriteLine("Ingrese el numero: ");
            n1 = int.Parse((Console.ReadLine()));

            //Devolucion
            resultado = n1 * n1;
            Console
                .WriteLine("El numero " +
                n1 +
                " al ser elevado al cubo es :" +
                resultado);
        }
    }
}
