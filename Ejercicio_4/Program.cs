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
            // Primer caso
            Console.Write("Ingresa producto: ");
            string producto = Console.ReadLine();

            Console.Write("Cantidad: ");
            string cantidadTexto = Console.ReadLine();

            if (productos.TryGetValue(producto, out double precio))
            {
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

            // Segundo caso
            Console.Write("\nIngresa producto: ");
            producto = Console.ReadLine();

            if (productos.TryGetValue(producto, out precio))
            {
                Console.Write("Cantidad: ");
                cantidadTexto = Console.ReadLine();

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

            // Tercer caso
            Console.Write("\nIngresa producto: ");
            producto = Console.ReadLine();

            Console.Write("Cantidad: ");
            cantidadTexto = Console.ReadLine();

            if (productos.TryGetValue(producto, out precio))
            {
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
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}
