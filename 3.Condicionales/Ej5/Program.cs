using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

             int N1, N2, N3, N4;

            Console.WriteLine("Ingrese el Primer Numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Tercer Numero: ");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Cuarto Numero: ");
            N4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros mayores a 100 son: ");

            if (N1>=100){
                Console.WriteLine($"{N1}");
            }
            if (N2>=100){
                Console.WriteLine($"{N2}");
            }
            if (N3>=100){
                Console.WriteLine($"{N3}");
            }
            if (N4>=100){
                Console.WriteLine($"{N4}");
            }
            if(N1<100 && N2<100 && N3<100 && N4<100){
                Console.WriteLine("Los numeros ingresados no superan el numero 100");
            
            }

        }
    }
}
