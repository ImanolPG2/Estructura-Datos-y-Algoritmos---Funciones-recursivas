using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa para calcular el Máximo Común Divisor (MCD) de forma recursiva");
        Console.WriteLine("Para salir, cierre la ventana manualmente.");

        while (true)
        {
            try
            {
                Console.Write("\nIngrese el primer número entero positivo (o 0 para salir): ");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 == 0)
                {
                    Console.WriteLine("¿Está seguro de que quiere salir? (S/N)");
                    if (Console.ReadLine().Trim().ToUpper() == "S")
                    {
                        break;
                    }
                    continue;
                }

                Console.Write("Ingrese el segundo número entero positivo: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("Error: Ambos números deben ser positivos.");
                    continue;
                }

                int mcd = CalcularMCD(num1, num2);
                Console.WriteLine($"El MCD de {num1} y {num2} es: {mcd}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese números enteros válidos.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
            }
        }

        Console.WriteLine("Gracias por usar el programa. Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static int CalcularMCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return CalcularMCD(b, a % b);
    }
}