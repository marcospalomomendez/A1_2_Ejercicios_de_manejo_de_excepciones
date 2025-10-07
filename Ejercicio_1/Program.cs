using System;

class Program
{
    static void Main()
    {
        // Variable que indica si el número ingresado es válido
        bool numeroValido = false;

        // Bucle que se repetirá hasta que el usuario ingrese un número válido
        while (!numeroValido)
        {
            Console.Write("Ingresa un número: ");
            string input = Console.ReadLine();

            // Intentar convertir el texto ingresado a un número entero
            if (int.TryParse(input, out int numero))
            {
                try
                {
                    // Verificar que el número no sea negativo
                    if (numero < 0)
                    {
                        // Lanzar una excepción si el número es negativo
                        throw new Exception("El número no puede ser negativo");
                    }

                    // Si todo está correcto, mostrar el número y salir del bucle
                    Console.WriteLine($"Número aceptado: {numero}");
                    numeroValido = true;
                }
                catch (Exception ex)
                {
                    // Captura la excepción y muestra un mensaje de error
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                // Si TryParse falla, significa que el usuario no ingresó un número válido
                Console.WriteLine("Valor no válido");
            }
        }
    }
}
