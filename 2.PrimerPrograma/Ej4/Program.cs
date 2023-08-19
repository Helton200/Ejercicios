using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado.
            //Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            float sueldo = 15000;
            float ComisionPorcentaje = 0.05f;
            float TFacturado;
            float TSueldo;

            Console.WriteLine("Ingresar el total facturado por el empleado: ");
            TFacturado = float.Parse(Console.ReadLine());

            float comisión = TFacturado * ComisionPorcentaje;
            TSueldo = sueldo + comisión;

            Console
                .WriteLine("El sueldo total del empleado es :" +
                TSueldo +
                " ARS");

        }
    }
}
