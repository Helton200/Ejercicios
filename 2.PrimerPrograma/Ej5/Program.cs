using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
            string NombreAlumno;
            float
                NotaA,
                NotaB,
                NotaC;
            float PromedioFinal;

            Console.WriteLine("Ingrese el Nombre del Alumno :");
            NombreAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese la Primer Nota del Alumno:");
            NotaA = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Segunda Nota del Alumno:");
            NotaB = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Tercer Nota del Alumno:");
            NotaC = float.Parse(Console.ReadLine());

            PromedioFinal = (NotaA + NotaB + NotaC) / 3;

            Console
                .WriteLine($"El promedio del Alumno {NombreAlumno} es: {PromedioFinal}");
        }
    }
}
