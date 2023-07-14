using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //El Ejercicio es una Calculadora
            // Paso 0 Crear Variables
            int n1;
            int n2;
            int resultado;

            //Paso 1, Pedir Valores
            Console
                .WriteLine("Esta calculadora esta hecha solamente para sumar");
            Console.WriteLine("Ingrese un Numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Siguiente Numero");
            n2 = int.Parse(Console.ReadLine());
            Console
                .WriteLine("El calculo de la suma de " +
                n1 +
                " y " +
                n2 +
                " es:");
            Console.WriteLine("Cargando.");

            resultado = n1 + n2;
            Console.WriteLine("Cargando..");
            Console.WriteLine("Cargando...");
            Console.WriteLine("El resultado es: " + resultado);
            //Paso 2, Ejecutar el Calculo
            //Mostrar el Resultado
        }
    }
}
