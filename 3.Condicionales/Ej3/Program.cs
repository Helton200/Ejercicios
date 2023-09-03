using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.

            float ImporteCompra;

            float DescuentoMasMil = 0.10f;
            float DescuentoMasCincoMil = 0.18f;
            float Descuento;
            float ImporteTotal;

            Console.WriteLine("Ingrese el importe de la compra: ");
            ImporteCompra = float.Parse(Console.ReadLine());



            if(ImporteCompra > 5000){
                Descuento = (ImporteCompra * DescuentoMasCincoMil);
                ImporteTotal = ImporteCompra - Descuento ;
                Console.WriteLine($"Su importe total es de: {ImporteTotal} ARS. Ademas obtuvo un descuento del {Descuento} ARS");
            } else if (ImporteCompra > 1000){
                Descuento = (ImporteCompra * DescuentoMasMil);
                ImporteTotal = ImporteCompra - Descuento;
                Console.WriteLine($"Su importe total es de: {ImporteTotal} ARS . Ademas obtuvo un descuento del {Descuento} ARS");
            } else {
                ImporteTotal = ImporteCompra;
                Console.WriteLine($"Su importe total es: {ImporteTotal}");
            }


        }
    }
}
