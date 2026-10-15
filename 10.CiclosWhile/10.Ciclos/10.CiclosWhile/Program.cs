using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CiclosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random rnd = new Random();
                int numeroSecreto = rnd.Next(1, 101);
                int intento = 0;

                Console.WriteLine("Adivina el numero entre 1 y 100");

                while (intento != numeroSecreto)
                {
                    Console.Write("Ingresa tu intento: ");
                    intento = int.Parse(Console.ReadLine());

                    if (intento > numeroSecreto)
                    {
                        Console.WriteLine("Demasiado alto.");
                    }
                    else if (intento < numeroSecreto)
                    {
                        Console.WriteLine("Demasiado bajo.");
                    }
                    else
                    {
                        Console.WriteLine("Correcto, adivinaste el numero!");
                    }

                }
            }
        }
    }
}
    

