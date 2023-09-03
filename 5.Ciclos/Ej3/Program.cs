using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.


            int edad, promedio, cont = 0, acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad>18){
                    cont++;
                    acumulador += edad;
                }

            }
            promedio = acumulador / cont;

            Console.WriteLine($"Entre las edades mayores a 18, el promedio es de: {promedio}");

        }
    }
}
