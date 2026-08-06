using System;


namespace _4.CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control condicional 
            //condicional simple
            //1.   crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"
            /* byte edad = 0;
              Console.WriteLine("Ingrese su edad");
              Edad = Convert.ToByte(Console.ReadLine());
              if(edad>=18)
              {
                  Console.WriteLine("Bienvenidos a mi pagina");
              }*/

            //crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos
            float sueldo = 0;
            string nombre;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su sueldo:");
            sueldo = Convert.ToSingle(Console.ReadLine());
            if (sueldo >= 3000)
            {
                Console.WriteLine("Usted" + nombre + "debes abonar impuestos");
            }
        }
    }
}
