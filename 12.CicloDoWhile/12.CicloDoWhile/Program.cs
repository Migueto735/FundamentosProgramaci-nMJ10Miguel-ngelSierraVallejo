using System;

namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int numcu;
            float saldo;
            int cont = 0;
            float acum = 0;
            int res;
            float prom;
            do
            {
                cont++;
                Console.WriteLine("Cual es su nombre?");
                nombre = Console.ReadLine();
                Console.WriteLine("Cual es el número de su cuenta");
                numcu = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                saldo = float.Parse(Console.ReadLine());
                acum += saldo;
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numcu}");
                    Console.WriteLine($"Cantidad de saldo: {saldo}");
                    Console.WriteLine("Usted es apto para el credito");
                }
                else
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numcu}");
                    Console.WriteLine($"Cantidad de saldo: {saldo}");
                    Console.WriteLine("Usted no es apto para el credito");
                }
                Console.WriteLine("Si desea agregar otro usuario presione 1, de lo contrario presione 2");
                res = int.Parse(Console.ReadLine());
            }
            while (res == 1);
            Console.WriteLine($"La cantidad de usuarios a la que se le pregunto fue:{cont}");
            prom = acum / cont;
            Console.WriteLine($"El promedio en los saldos fue:{prom}");
        }

    }
}
}
