using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Crear una lista de palabras
        List<string> palabras = new List<string> { "A", "B", "C", "D", "E" };


        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ingresa índice: ");
            string entrada = Console.ReadLine();

            // Validar que sea un número
            if (int.TryParse(entrada, out int indice))
            {
                // Acceso seguro con ElementAtOrDefault
                string palabra = palabras.ElementAtOrDefault(indice);

                if (palabra != null)
                    Console.WriteLine($"Palabra: \"{palabra}\"");
                else
                    Console.WriteLine("Índice fuera de rango");
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }
        }
    }
}
