using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo.
            //Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            //Ingresar Km Existentes entre dos ciudades, y la velocidad promedio
            int km;
            int vel;
            float promedio;

            //Solcitar los datos
            Console
                .WriteLine("Ingresar los km existentes entre su destino y su ubicacion actual: ");
            km = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su velocidad promedio actual: ");
            vel = int.Parse(Console.ReadLine());

            //Calcular el tiempo que demandara en llegar de un punto al otro
            promedio = km / vel;

            //Mostrar en pantalla el tiempo
            Console
                .WriteLine("El tiempo promedio para llegar a su destino es de: " +
                promedio +
                " hs");
        }
    }
}
