using System;

namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- PUNTO 17 ---");

            Console.Write("Ingrese el numero de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese valor para la posicion [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Ingrese el valor limite u objetivo (N): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] < n)
                    {
                        matriz[i, j] = n;
                    }
                }
            }

            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
