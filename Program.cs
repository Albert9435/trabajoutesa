using System;

class Program
{
    static void Main(string[] args)
    {
        MenuPrincipal();
    }

    static void MenuPrincipal()
    {
        // en este grupo hay un venao

        string opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("Universidad Tecnologica de Santiago");
            Console.WriteLine("UTESA - Sistema Corporativo");
            Console.WriteLine("Entrega final de Algoritmos y estructura de Datos");
            Console.WriteLine("==============================================");
            Console.WriteLine("\nMENU PRINCIPAL");
            Console.WriteLine("1. Numeros");
            Console.WriteLine("2. Estadistica");
            Console.WriteLine("3. Conversion");
            Console.WriteLine("4. Metodos de ordenamiento");
            Console.WriteLine("5. Recursividad");
            Console.WriteLine("6. Arbol de decisiones");
            Console.WriteLine("7. Grafos");
            Console.WriteLine("0. Salir");
            Console.Write("\nDigita la opcion: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Menú de Números (por implementar)");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Menú de Estadística (por implementar)");
                    Console.ReadKey();
                    break;
                case "3":
                    MenuConversion();
                    break;
                case "4":
                    Console.WriteLine("Menú de Métodos de ordenamiento (por implementar)");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.WriteLine("Menú de Recursividad (por implementar)");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.WriteLine("Menú de Árbol de decisiones (por implementar)");
                    Console.ReadKey();
                    break;
                case "7":
                    Console.WriteLine("Menú de Grafos (por implementar)");
                    Console.ReadKey();
                    break;
                case "0":
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != "0");
    }

    static void MenuConversion()
    {
        string opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("Universidad Tecnologica de Santiago");
            Console.WriteLine("UTESA - Sistema Corporativo");
            Console.WriteLine("Entrega final de Algoritmos y estructura de Datos");
            Console.WriteLine("==============================================");
            Console.WriteLine("\nMENU CONVERSION");
            Console.WriteLine("a. Binario");
            Console.WriteLine("b. Octal");
            Console.WriteLine("c. Hexadecimal");
            Console.WriteLine("d. Romano");
            Console.WriteLine("x. Volver al menu principal");
            Console.Write("\nDigita la opcion: ");
            opcion = Console.ReadLine().ToLower();

            switch (opcion)
            {
                case "a":
                    ConvertirABinario();
                    break;
                case "b":
                    ConvertirAOctal();
                    break;
                case "c":
                    ConvertirAHexadecimal();
                    break;
                case "d":
                    ConvertirARomano();
                    break;
                case "x":
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != "x");
    }

    static void ConvertirABinario()
    {
        Console.Clear();
        Console.Write("Ingresa un número decimal: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine($"Binario: {binario}");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
        Console.WriteLine("Presiona una tecla para volver...");
        Console.ReadKey();
    }

    static void ConvertirAOctal()
    {
        Console.Clear();
        Console.Write("Ingresa un número decimal: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string octal = Convert.ToString(numero, 8);
            Console.WriteLine($"Octal: {octal}");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
        Console.WriteLine("Presiona una tecla para volver...");
        Console.ReadKey();
    }

    static void ConvertirAHexadecimal()
    {
        Console.Clear();
        Console.Write("Ingresa un número decimal: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string hex = Convert.ToString(numero, 16).ToUpper();
            Console.WriteLine($"Hexadecimal: {hex}");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
        Console.WriteLine("Presiona una tecla para volver...");
        Console.ReadKey();
    }

    static void ConvertirARomano()
    {
        Console.Clear();
        Console.Write("Ingresa un número decimal (1 - 3999): ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero < 4000)
        {
            string romano = ConvertirDecimalARomano(numero);
            Console.WriteLine($"Número romano: {romano}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ser entre 1 y 3999.");
        }
        Console.WriteLine("Presiona una tecla para volver...");
        Console.ReadKey();
    }

    static string ConvertirDecimalARomano(int numero)
    {
        string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string resultado = "";

        for (int i = 0; i < valores.Length; i++)
        {
            while (numero >= valores[i])
            {
                numero -= valores[i];
                resultado += romanos[i];
            }
        }
        return resultado;
    }
}
