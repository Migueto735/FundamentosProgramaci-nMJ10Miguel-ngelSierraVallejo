using System;

namespace Parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constantes
            const int capacidad_maxima = 40;
            const double tarifa_general = 12000;
            const double tarifa_preferencial = 20000;
            const double tarifa_VIP = 30000;

            // Contadores y acumuladores
            int totalBoletas = 0;
            int boletasGeneral = 0;
            int boletasPreferencial = 0;
            int boletasVIP = 0;
            double dineroTotalRecaudado = 0;

            Console.WriteLine("=== Sistema de taquilla - Cine Metrópolis ===");

            // Ciclo principal
            while (totalBoletas < capacidad_maxima)
            {
                Console.WriteLine($"\nAsientos ocupados: {totalBoletas}/{capacidad_maxima}");
                Console.WriteLine("Seleccione la zona:");
                Console.WriteLine("1. General ($12.000)");
                Console.WriteLine("2. Preferencial ($20.000)");
                Console.WriteLine("3. VIP ($30.000)");
                Console.WriteLine("0. Cerrar taquilla");
                Console.Write("Opción: ");

                string entradaOpcion = Console.ReadLine();
                int opcion;

                // Validación de entrada numérica
                if (!int.TryParse(entradaOpcion, out opcion) || opcion < 0 || opcion > 3)
                {
                    Console.WriteLine(" Error: Opción inválida. Intentar de nuevo.");
                    continue; // Vuelve a pedir la opción sin avanzar
                }

                // Condición de salida por decisión del cajero
                if (opcion == 0)
                {
                    Console.WriteLine("\nCierre de taquilla solicitado por el cajero.");
                    break;
                }

                // Determinar tarifa base según la opción
                double tarifaBase = 0;
                if (opcion == 1)
                {
                    tarifaBase = tarifa_general;
                }
                else if (opcion == 2)
                {
                    tarifaBase = tarifa_preferencial;
                }
                else if (opcion == 3)
                {
                    tarifaBase = tarifa_VIP;
                }

                // Solicitud y validación del tipo de cliente
                string tipoCliente = "";
                while (tipoCliente != "E" && tipoCliente != "G")
                {
                    Console.Write("¿El cliente es Estudiante (E) o General (G)?: ");
                    tipoCliente = Console.ReadLine().ToUpper().Trim();

                    if (tipoCliente != "E" && tipoCliente != "G")
                    {
                        Console.WriteLine(" Error: Ingrese únicamente 'E' para Estudiante o 'G' para General.");
                    }
                }

                // Cálculo con condicionales anidados para aplicar descuento
                double totalPagar = tarifaBase;
                if (tipoCliente == "E")
                {
                    totalPagar = tarifaBase * 0.90; // 10% de descuento
                }

                // Actualizar contadores globales y acumuladores
                totalBoletas++;
                dineroTotalRecaudado += totalPagar;

                if (opcion == 1) boletasGeneral++;
                else if (opcion == 2) boletasPreferencial++;
                else if (opcion == 3) boletasVIP++;

                // Mostrar resultado de la transacción
                Console.WriteLine($" Total a pagar por este cliente: ${totalPagar:N0}");

                // Validación de aforo lleno
                if (totalBoletas == capacidad_maxima)
                {
                    Console.WriteLine("\n¡Sala llena! Fin de la función.");
                }
            }

            // Reporte final de cierre
            Console.WriteLine("\n========================================");
            Console.WriteLine("      reporte de cierre de taquilla    ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Dinero total recaudado: ${dineroTotalRecaudado:N0}");
            Console.WriteLine($"Boletas vendidas en General: {boletasGeneral}");
            Console.WriteLine($"Boletas vendidas en Preferencial: {boletasPreferencial}");
            Console.WriteLine($"Boletas vendidas en VIP: {boletasVIP}");
            Console.WriteLine($"Total de boletas vendidas: {totalBoletas}");
            Console.WriteLine($"Asientos desocupados / vacíos: {capacidad_maxima - totalBoletas}");
            Console.WriteLine("========================================");

        }
    }
}
