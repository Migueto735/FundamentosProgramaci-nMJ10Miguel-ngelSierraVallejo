using System;

namespace _2.ConstanteTiposDOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva = "19%";
            string nombre = "Miguel";
            nombre = "Sierra";
            //iva = "20%"; que a una constante no se le puede cambiar su valor

            //Tipos de Datos 
            byte dato1 = 255;//de 0 a 255
            int dato2 = -256;//enteros
            ulong dato3 = 1236333;//enteros mas grandes
            float dato4 = 6.7f;//decimales pequeños (se pone una f siempre al final)
            double dato5 = 2123.3265d;//decimales mas grandes
            char dato6 = ' ';//almacena un solo caracter
            string dato7 = "lkfutureo6767))((//--xd";//serie de caracteres (frases, oraciones, etc...)
            bool dato8 = false; //true or false
            object dato9 = new object();

            //operadores
            //numericos
            //cambio de signo
            int dato10 = 7;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            Console.WriteLine("dato 10: {0}, dato 11:{1}, dato:{2}, dato13:{13}", dato10, dato11, dato12, dato13);
            //Operadores aritméticos
            int dato14 = 5 + 3;//suma
            int dato15 = dato14 - 2;//resta
            int dato16 = 10 * 3;//producto
            //float dato17 = 5.0f / 3.0f;
            //float dato17 =(float) 5 / 3
            float dato17 = 5f / 3f.;//división
            Console.WriteLine("suma:{0}, resta: {1}, producto{2}, división{3}", dato14, dato15, dato16, dato17);

            //Incremento - decremento
            int dato18 = 1;
            dato18++;//dato18=dato18+1;
            dato18--;//dato18=dato-1;
            dato18 += 3;//dato18=dato18+3
            dato18 -= 2;//dato18=dato18-2
            dato18 *= 5;//dato18=dato18*5
            dato18 /= 3;//dato18=dato18/3
        }
    }
}
