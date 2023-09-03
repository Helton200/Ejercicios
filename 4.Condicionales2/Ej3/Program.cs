using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

                        i5 (1)	    i7 (2)	    i9 (3)
           8 RAM (1)	USD 800	    USD 900	    USD 1200
          16 RAM (2)	USD 900	    USD 1000	USD 1400
          32 RAM (3)    USD 1000	USD 1400	USD 2000
                
            Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.*/

            int Procesador, Ram,Disco;
            int Presupuesto = 0;
            Console.WriteLine("Ingrese el procesador de su gusto entre estas opciones: \n 1) I5 \n 2) I7 \n 3) I9 ");
            Procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Ram de su gusto entre estas opciones: \n 1) 8 Ram \n 2) 16 Ram \n 3) 32 Ram ");
            Ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea ampliar su disco a 1TB?: \n 1) Si \n 2) No");;
            Disco = int.Parse(Console.ReadLine());


            if (Procesador==1){
                if (Ram==1){
                    Presupuesto = 800;
                    if(Disco==1){
                        Presupuesto += 300;
                    }
                } else if (Ram==2){
                    Presupuesto = 900;
                    if (Disco==1){
                        Presupuesto += 300;
                    }
                } else if (Ram==3){
                    Presupuesto = 1000;
                 if(Disco==1){
                    Presupuesto += 300;
                    }
                }
            } else if (Procesador==2){
                if (Ram==1){
                    Presupuesto = 900;
                    if(Disco==1){
                        Presupuesto += 300;
                    }
                } else if (Ram==2){
                    Presupuesto = 1000;
                    if (Disco==1){
                        Presupuesto += 300;
                    }
                } else if (Ram==3){
                    Presupuesto = 1400;
                 if(Disco==1){
                    Presupuesto += 300;
                    }
                }
            } else if (Procesador==3){
                if (Ram==1){
                    Presupuesto = 1200;
                    if(Disco==1){
                        Presupuesto += 300;
                    }
                } else if (Ram==2){
                    Presupuesto = 1400;
                    if (Disco==1){
                        Presupuesto += 300;
                    }
                } else if (Ram==3){
                    Presupuesto = 2000;
                 if(Disco==1){
                    Presupuesto += 300;
                    }
                }
            }

            Console.WriteLine($"El precio total de su compra es : {Presupuesto}");

        }
    }
}
