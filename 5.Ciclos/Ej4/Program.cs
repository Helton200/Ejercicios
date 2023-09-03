using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            int num,a=0;

            Console.WriteLine("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

             for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine(num+ " No es primo");
            }
            else
            {
                Console.WriteLine(num+ " Si es primo");
            }
        }
    }
}
