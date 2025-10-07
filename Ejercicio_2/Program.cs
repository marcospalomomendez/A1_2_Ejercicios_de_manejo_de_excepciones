using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear el diccionario con los alumnos y sus edades
        Dictionary<string, int> alumnos = new Dictionary<string, int>()
        {
            { "Ana", 25 },
            { "Luis", 30 }
        };

        // Primera búsqueda
        Console.Write("Ingresa nombre del alumno: ");
        string nombre = Console.ReadLine();

        int edad;
        if (alumnos.TryGetValue(nombre, out edad))
        {
            Console.WriteLine($"Edad: {edad}");
        }
        else
        {
            Console.WriteLine("Alumno no encontrado");
        }

        // Segunda búsqueda
        Console.Write("Ingresa nombre del alumno: ");
        nombre = Console.ReadLine();

        if (alumnos.TryGetValue(nombre, out edad))
        {
            Console.WriteLine($"Edad: {edad}");
        }
        else
        {
            Console.WriteLine("Alumno no encontrado");
        }
    }
}
