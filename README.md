# maquina-expendedora-csharp
Simulador de maquina expendedora de sodas desarrollado en c++ como practica escolar.

using System;
using System.Collections.Generic;

class MaquinaExpendedora
{
    static void Main()
    {
        // Bebidas y precios - ¡Aquí puedes cambiarlos!
        Dictionary<string, double> bebidas = new Dictionary<string, double>()
        {
            { "1. Coca-Cola", 18.00 },
            { "2. Fanta de Naranja", 15.00 },
            { "3. Monster Energy", 35.00 },
            { "4. Agua Ciel", 12.00 },
            { "5. Jumex de Mango", 20.00 }
        };

        double saldo = 0;

        Console.WriteLine("=================================");
        Console.WriteLine("  BIENVENIDO A MI MAQUINA EXPENDEDORA ");
        Console.WriteLine("=================================");

        while (true)
        {
            Console.WriteLine("\n--- MENÚ ---");
            foreach (var bebida in bebidas)
            {
                Console.WriteLine($"{bebida.Key} - ${bebida.Value}");
            }
            Console.WriteLine("6. Salir");
            Console.WriteLine($"\nTu saldo actual: ${saldo}");

            Console.Write("\nIngresa tu dinero: $");
            double dinero = Convert.ToDouble(Console.ReadLine());
            saldo += dinero;

            Console.Write("Elige el número de tu bebida (1-5) o 6 para salir: ");
            string opcion = Console.ReadLine();

            if (opcion == "6")
            {
                Console.WriteLine($"Gracias por tu compra! Tu cambio es: ${saldo}");
                break;
            }

            string bebidaElegida = "";
            double precio = 0;

            switch (opcion)
            {
                case "1": bebidaElegida = "Coca-Cola"; precio = 18.00; break;
                case "2": bebidaElegida = "Fanta de Naranja"; precio = 15.00; break;
                case "3": bebidaElegida = "Monster Energy"; precio = 35.00; break;
                case "4": bebidaElegida = "Agua Ciel"; precio = 12.00; break;
                case "5": bebidaElegida = "Jumex de Mango"; precio = 20.00; break;
                default: Console.WriteLine("Opción no válida"); continue;
            }

            if (saldo >= precio)
            {
                saldo -= precio;
                Console.WriteLine($"\n¡Disfruta tu {bebidaElegida}! 🥤");
                Console.WriteLine($"Tu cambio es: ${saldo}");
                saldo = 0;
            }
            else
            {
                Console.WriteLine($"\nTe falta dinero. Te faltan ${precio - saldo}");
            }
        }
    }
}
