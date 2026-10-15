using System;

namespace _8.CiclosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los numeros ingresados

            int sumaEnterosPositivos = 0; // acumulador
            int numero = 0;

            Console.WriteLine("ingrese un número para sumar. Ingrese -1 para terminar");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0) 
            {
                sumaEnterosPositivos += numero;
                Console.WriteLine("ingrese un número para sumar. Ingrese -1 para terminar");
                numero = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"la suma de los numeros positivos ingresados es: {sumaEnterosPositivos}");

        }
    }
}
