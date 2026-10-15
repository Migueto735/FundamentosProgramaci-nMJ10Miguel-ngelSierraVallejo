using System;

namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static void MostrarMenu()
        {
            Console.WriteLine("------------MENÚ------------");
            Console.WriteLine("  1. Suma                   ");
            Console.WriteLine("  2. Resta                  ");
            Console.WriteLine("  3. Multiplicación         ");
            Console.WriteLine("  4. Divición               ");
            Console.WriteLine("  0. Salir                  ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ingrese una opccion del menú");
        }

        static int CapturarOpcion()
        {
            return int .Parse(Console.ReadLine());
        }

        static void RealizarOperaciones(int opcion)
        {
            while (opcion != 0)
            {

               switch (opcion)
               {
                   case 1:
                       Console.WriteLine("SUMA");
                       Console.WriteLine($"{Suma()}");
                       break;
 
                   case 2:
                       Console.WriteLine("RESTA");
                       Console.WriteLine($"{Resta()}");
                       break;

                   case 3:
                       Console.WriteLine("MULTIPLICACIÓN");
                       Console.WriteLine($"{Multiplicacion()}");
                       break;

                   case 4:
                       Console.WriteLine("DIVISIÓN");
                       Console.WriteLine($"{Division()}");
                       break;
               }

               Console.ReadKey();
               Console.Clear();
               MostrarMenu();
               opcion = CapturarOpcion();

            }
        }
        
        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;

            do
            {
                Console.WriteLine("Ingrese los numeros que quiere sumar");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea seguir sumando (+: continuar)");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == '+');

            return suma;    
        }

        static float Resta()
        {
            Console.WriteLine(" ");
            float numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" - ");
            float nummero2 = int.Parse(Console.ReadLine());

            return numero1 - nummero2;

        }

        static float Multiplicacion()
        {
            float multiplicacion = 1;
            char respuesta = ' ';
            float numero = 1;

            do
            {
                Console.WriteLine("Ingrese los numeros que quiere multiplicar");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea seguir sumando (x: continuar)");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 'x');

            return multiplicacion;
        }

        static float Division()
        {
            Console.WriteLine(" ");
            float numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("/");
            float nummero2 = int.Parse(Console.ReadLine());

            return numero1 / nummero2;

        }
    }
}
