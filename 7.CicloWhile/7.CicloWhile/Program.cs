using System;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Escribir un algoritmo que permite generar los primeros 5 números enteros positivos y realizar y mostrar su suma.
            int contador = 1;
            int acumulador = 0;

            while (contador <=5)
            {
                acumulador = acumulador + contador;
                contador++;

            }

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");
        }
    }
}
