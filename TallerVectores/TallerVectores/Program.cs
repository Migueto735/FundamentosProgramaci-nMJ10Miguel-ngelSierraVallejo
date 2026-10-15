using System;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego encuentre y muestre el valor máximo y mínimo de los números ingresados.

            int[] numeros = new int[15];
            int NumMayor = 0;
            int NumMenor = 0;

            Console.WriteLine($"Ingrese los 15 numeros enteros que desee");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    NumMayor = numeros[i];
                    NumMenor = numeros[i];
                }

                if (numeros[i] < NumMenor)
                {
                    NumMenor = numeros[i];
                }

                else if (numeros[i] > NumMayor)
                {
                    NumMayor = numeros[i];
                }
            }

            Console.WriteLine($"El numero mayor es: {NumMayor}");
            Console.WriteLine($"El numero menor es: {NumMenor}");



            /*Escribir un algoritmo que permita:
            a.Crear dos vectores del mismo tamaño. 
            b.Llenarlos con números.
            c.Comparar posición por posición.
            d.Indicar cuántos elementos son iguales*/

            {
                int[] vector1 = new int[10];
                int[] vector2 = new int[10];

                int iguales = 0;

                // Llenar el primer vector
                Console.WriteLine("Ingrese los números del primer vector:");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Número " + (i + 1) + ": ");
                    vector1[i] = int.Parse(Console.ReadLine());
                }

                // Llenar el segundo vector
                Console.WriteLine("\nIngrese los números del segundo vector:");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Número " + (i + 1) + ": ");
                    vector2[i] = int.Parse(Console.ReadLine());
                }

                // Comparar posición por posición
                for (int i = 0; i < 10; i++)
                {
                    if (vector1[i] == vector2[i])
                    {
                        iguales++;
                    }
                }

                // Mostrar resultado
                Console.WriteLine("\nCantidad de elementos iguales: " + iguales);

                /*Escribir un algoritmo que permita:
                a.Llenar un vector[20] con números enteros(positivos o negativos) ingresados por el
                usuario o generados aleatoriamente.
                b.Calcular y mostrar el promedio aritmético de todos los elementos almacenados en
                el vector.
                c.Recorrer nuevamente el vector para contar e indicar cuántos números son
                mayores que el promedio y cuántos son menores que este. 
                d.Mostrar en pantalla el vector completo junto con los resultados obtenidos.*/
                


            }
        }
    }
   
}


