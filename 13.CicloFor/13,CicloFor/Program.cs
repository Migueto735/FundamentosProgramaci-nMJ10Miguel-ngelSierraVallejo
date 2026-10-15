using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo For

            int acumulador = 0;

            for ( int contador=1; contador<=5; contador++ )
            {
                acumulador+= contador;
            }
            Console.WriteLine( $"la suma de los primeros 5 numeros positivos enteros es: {acumulador}");
        }
    }
}
