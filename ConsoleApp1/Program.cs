using System;

class Program
{
    static void Main()
    {
        // Solicitar información al usuario
        Console.Write("Ingrese Apellido y Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese Dirección: ");
        string direccion = Console.ReadLine();

        Console.Write("Ingrese Ciudad: ");
        string ciudad = Console.ReadLine();

        Console.Write("Ingrese Teléfono: ");
        string telefono = Console.ReadLine();

        // Mostrar el mensaje
        Console.WriteLine($"La persona: {nombre} vive en {direccion} - {ciudad}. Número telefónico: {telefono}");

        // Definir e inicializar variables de diferentes tipos
        bool booleano = true;
        byte miByte = 100;
        char miChar = 'A';
        decimal miDecimal = 123.45m;
        double miDouble = 3.14;
        float miFloat = 2.71f;
        int miInt = 42;
        long miLong = 1234567890L;
        short miShort = 32767;
        string miString = "Hola, mundo!";

        // Mostrar el contenido de cada variable
        Console.WriteLine($"bool: {booleano}");
        Console.WriteLine($"byte: {miByte}");
        Console.WriteLine($"char: {miChar}");
        Console.WriteLine($"decimal: {miDecimal}");
        Console.WriteLine($"double: {miDouble}");
        Console.WriteLine($"float: {miFloat}");
        Console.WriteLine($"int: {miInt}");
        Console.WriteLine($"long: {miLong}");
        Console.WriteLine($"short: {miShort}");
        Console.WriteLine($"string: {miString}");

        // Mostrar los valores mínimo y máximo de los tipos numéricos
        Console.WriteLine($"Valor mínimo de byte: {byte.MinValue}");
        Console.WriteLine($"Valor máximo de byte: {byte.MaxValue}");
        Console.WriteLine($"Valor mínimo de int: {int.MinValue}");
        Console.WriteLine($"Valor máximo de int: {int.MaxValue}");
        Console.WriteLine($"Valor mínimo de long: {long.MinValue}");
        Console.WriteLine($"Valor máximo de long: {long.MaxValue}");
        Console.WriteLine($"Valor mínimo de short: {short.MinValue}");
        Console.WriteLine($"Valor máximo de short: {short.MaxValue}");

        // Aquí se producirán errores de compilación
        // int numero = "string"; // Error: No se puede asignar una cadena a una variable de tipo int.
        // string cadena = 2;     // Error: No se puede asignar un entero a una variable de tipo string.
        // bool booleano = "true"; // Error: No se puede asignar una cadena a una variable de tipo bool.

        Console.ReadLine(); // Espera a que el usuario presione Enter para salir.
    }
}

