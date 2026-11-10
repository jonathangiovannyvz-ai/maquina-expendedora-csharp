using System;
using System.Collections.Generic;

class MaquinaExpendedora
{
    static void Main()
    {
        Dictionary<string, double> bebidas = new Dictionary<string, double>()
        {
            {"1. Coca-Cola", 18},
            {"2. Fanta de Naranja", 15},
            {"3. Monster Energy", 35},
            {"4. Agua Ciel", 12},
            {"5. Jumex de Mango", 20}
        };

        Console.WriteLine("================================");
        Console.WriteLine("  BIENVENIDO A MI MAQUINA EXPENDEDORA");
        Console.WriteLine("================================");
        Console.WriteLine("Bebidas disponibles:");

        foreach (var bebida in bebidas)
        {
            Console.WriteLine(bebida.Key + " - $" + bebida.Value);
        }

        Console.Write("\nIngresa tu dinero: $");
        double saldo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Elige tu bebida (1-5): ");
        string opcion = Console.ReadLine();

        string bebidaElegida = "";
        double precio = 0;

        switch (opcion)
        {
            case "1": bebidaElegida = "Coca-Cola"; precio = 18; break;
            case "2": bebidaElegida = "Fanta de Naranja"; precio = 15; break;
            case "3": bebidaElegida = "Monster Energy"; precio = 35; break;
            case "4": bebidaElegida = "Agua Ciel"; precio = 12; break;
            case "5": bebidaElegida = "Jumex de Mango"; precio = 20; break;
            default: Console.WriteLine("Opcion no valida"); return;
        }

        if (saldo >= precio)
        {
            double cambio = saldo - precio;
            Console.WriteLine("\nDispensando tu " + bebidaElegida + "...");
            Console.WriteLine("Tu cambio es: $" + cambio);
            Console.WriteLine("¡Disfruta tu bebida! Gracias por tu compra");
        }
        else
        {
            Console.WriteLine("Dinero insuficiente. Te faltan $" + (precio - saldo));
        }
    }
}
