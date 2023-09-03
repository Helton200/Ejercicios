using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

            int Importe, Litros;
            float resultado;

            Console.WriteLine("Ingrese el importe total de su compra: ");
            Importe = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de Litros solicitado: ");
            Litros = int.Parse(Console.ReadLine());

            if(Litros>100 && Litros<=300){
                resultado = Importe * 0.9f;
            } else if(Litros>=301 && Litros<=500){
                resultado = Importe * 0.85f;
            } else if(Litros>500){
                resultado = Importe * 0.75f;
            } else {
                resultado = Importe;
            }
            Console.WriteLine($"Su total a pagar es: {resultado}");
        }
    }
}
