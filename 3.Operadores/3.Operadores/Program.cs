using System;
using System.Runtime.InteropServices;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Orden de evaluaciones operadores numéricos 
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3f * 2f;
            float dato3 = 4f * (2f / 3f);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);

            Console.Write(dato5);

            //Operadores Logicos:
            //Conjunción - AND - Y - &&
            Console.WriteLine("-----------------");
            Console.WriteLine("Tabla de conjunción");
            Console.WriteLine("V && V =" + (true && true));
            Console.WriteLine("V && F =" + (true && false));
            Console.WriteLine("F && V =" + (false && true));
            Console.WriteLine("F && f =" + (false && false));
            Console.WriteLine("-----------------");

            //Disyunción - OR - O ||
            Console.WriteLine("Tabla de Diyunción");
            Console.WriteLine("V || V =" + (true || true));
            Console.WriteLine("V || F =" + (true || false));
            Console.WriteLine("F || V =" + (false || true));
            Console.WriteLine("F || F =" + (false || false));
            Console.WriteLine("------------------");

            //Operador logico de negación !
            bool dato8 = true;
            bool dato9 = !dato8;

            //Operadores de comparación
            bool dato6 = 5 > 4;
            bool dato7 = 100 == 99;
            bool dato10 = 1002 != 102;
            bool dato11 = 10 >= 10;
            bool dato12 = 12 < 11 && 0 == 1;
            bool dato13 = dato8 && 0 != 10 || !dato10;
        }
    }
}
