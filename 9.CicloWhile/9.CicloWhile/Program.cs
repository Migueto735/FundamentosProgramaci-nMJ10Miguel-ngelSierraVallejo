using System;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.
              El algoritmo debe escribir en pantalla:
            - La cantidad de números introducidos que son mayores que 0
            - La cantidad de números introducidos menores que 0
            - La cantidad de números iguales a 0.*/

            int cantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;

            Console.WriteLine("Ingrese la cantidad de números a evaluar");
            cantidadNumeros = int.Parse(Console.ReadLine());

            while (contador<cantidadNumeros)
            {
                contador++;
                Console.WriteLine("Ingrese el número a evaluar");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    contadorPositivos++;
                }
                else
                {
                    if (numero  < 0) 
                    {
                }
            }
        }
    }
}
