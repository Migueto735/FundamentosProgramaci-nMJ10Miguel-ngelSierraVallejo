using System;

namespace Parcial_1_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Solicitar el mes de nacimiento y el signo zodiacal 
            Console.Write("Ingrese su mes de nacimiento: ");
            string mes = Console.ReadLine();

            Console.Write("Ingrese su signo zodiacal ");
            string signo = Console.ReadLine();

            // Variables con las reglas definidas en la tabla
            bool esFuego = (mes == "marzo" || mes == "abril" || mes == "julio" || mes == "agosto" || mes == "noviembre" || mes == "diciembre") && (signo == "aries" || signo == "leo" || signo == "sagitario");

            bool esTierra = (mes == "abril" || mes == "mayo" || mes == "agosto" || mes == "septiembre" || mes == "diciembre" || mes == "enero") && (signo == "tauro" || signo == "virgo" || signo == "capricornio");

            bool esAire = (mes == "mayo" || mes == "junio" || mes == "septiembre" || mes == "octubre" || mes == "enero" || mes == "febrero") && (signo == "géminis" || signo == "libra" || signo == "acuario");

            bool esAgua = (mes == "marzo" || mes == "junio" || mes == "octubre" || mes == "noviembre" || mes == "febrero") && (signo == "cáncer" || signo == "escorpión" || signo == "piscis");

            // 3 y 4. Analizar datos y determinar elementos
            Console.WriteLine();
            if (esFuego)
            {
                Console.WriteLine("El elemento de la persona es Fuego");
            }
            else if (esTierra)
            {
                Console.WriteLine("El elemento de la persona es Tierra");
            }
            else if (esAire)
            {
                Console.WriteLine("El elemento de la persona es Aire");
            }
            else if (esAgua)
            {
                Console.WriteLine("El elemento de la persona es Agua");
            }
            else
            {
                // 5. Mensaje cuando los datos no coinciden
                Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
            }

        }
    }
}
