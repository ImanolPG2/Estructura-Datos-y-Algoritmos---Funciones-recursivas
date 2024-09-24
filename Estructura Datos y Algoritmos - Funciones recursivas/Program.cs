using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Potencia Recursiva");
        Console.WriteLine("Para salir, cierre la ventana manualmente.");

        while (true)
        {
            try
            {
                Console.Write("\nIngrese la base (o presione Ctrl+C para salir): ");
                double baseNum = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el exponente (entero no negativo): ");
                int exponente = int.Parse(Console.ReadLine());

                if (exponente < 0)
                {
                    Console.WriteLine("Error: El exponente debe ser no negativo.");
                    continue;
                }

                double resultado = CalcularPotencia(baseNum, exponente);
                Console.WriteLine($"{baseNum}^{exponente} = {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada inválida. Por favor, ingrese números válidos.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
            }
        }
    }

    static double CalcularPotencia(double baseNum, int exponente)
    {
        if (exponente == 0)
        {
            return 1;
        }
        else
        {
            return baseNum * CalcularPotencia(baseNum, exponente - 1);
        }
    }
}