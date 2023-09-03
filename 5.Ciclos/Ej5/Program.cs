using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            int num, max=0, min=0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());

                if( (num % 2) ==0){
                    if (num>max){
                        max = num;
                    }
                } else if (min == 0 || num<min){
                    min = num;
                }
            }
            
                Console.WriteLine($"El Mayor numero par es : {max}");
                Console.WriteLine($"El Menor numero Impar es : {min}");
        }
    }
}
