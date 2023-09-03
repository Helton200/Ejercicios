using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 10){
                Console.WriteLine("La edad ingresada es mayor a 10 años");
            }
            else{
                Console.WriteLine("La edad ingresada es menor a 10 años");
            }
        }
    }
}
