using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Diccionario con productos y precios
        Dictionary<string, double> productos = new Dictionary<string, double>()
        {
            { "Laptop", 1500 },
            { "Mouse", 25 },
            { "Teclado", 45 }
        };

        try
        {

            for (int i = 0; i < 3; i++)
            {
                // Segundo caso
                Console.Write("\nIngresa producto: ");
                string producto = Console.ReadLine();

                if (productos.TryGetValue(producto, out double precio))
                {
                    Console.Write("Cantidad: ");
                    string cantidadTexto = Console.ReadLine();

                    if (int.TryParse(cantidadTexto, out int cantidad))
                    {
                        double total = precio * cantidad;
                        Console.WriteLine($"Total: {total}");
                    }
                    else
                    {
                        Console.WriteLine("Cantidad no válida");
                    }
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}
