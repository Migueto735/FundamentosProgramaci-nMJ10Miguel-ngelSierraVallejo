using System;

namespace _20.ProgramaciónModular
{
    internal class Program
    {

        

            static void LlenarMatriz(int[,] matriz, int filas, int columnas)

            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        int numero;

                        do
                        {
                            Console.Write("Ingrese un multiplo de 5: ");
                            numero = int.Parse(Console.ReadLine());

                            if (numero % 5 != 0)
                            {
                                Console.WriteLine("Error, el numero no es multiplo de 5.");
                            }

                        } while (numero % 5 != 0);

                        matriz[i, j] = numero;
                    }
                }
            }

            static void MostrarMatriz(int[,] matriz, int filas, int columnas)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }

                    Console.WriteLine();
                }
            }

            static void Main(string[] args)
            {
                Console.Write("Ingrese el numero de filas: ");
                int filas = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el numero de columnas: ");
                int columnas = int.Parse(Console.ReadLine());

                int[,] matriz = new int[filas, columnas];

                LlenarMatriz(matriz, filas, columnas);

                Console.WriteLine("\nMatriz resultante:");
                MostrarMatriz(matriz, filas, columnas);

                Console.ReadKey();
            }
        }

    }
