using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa para invertir cadenas de forma recursiva");
        Console.WriteLine("Para salir, cierre la ventana manualmente.");

        while (true)
        {
            Console.Write("\nIngrese una cadena para invertir (o presione Enter sin texto para salir): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Cadena vacía detectada. ¿Está seguro de que quiere salir? (S/N)");
                if (Console.ReadLine().Trim().ToUpper() == "S")
                {
                    break;
                }
                continue;
            }

            string invertida = InvertirCadena(input);
            Console.WriteLine($"Cadena original: {input}");
            Console.WriteLine($"Cadena invertida: {invertida}");
        }

        Console.WriteLine("Gracias por usar el programa. Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static string InvertirCadena(string str)
    {
        if (str.Length <= 1)
        {
            return str;
        }
        return InvertirCadena(str.Substring(1)) + str[0];
    }
}