using System;

class Program
{
    static void Main()
    {
        // Se solicita la cantidad de productos al usuario
        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Se solicita el precio unitario del producto
        Console.Write("Ingrese el precio unitario: ");
        decimal precioUnitario = decimal.Parse(Console.ReadLine());

        // Se llama a la función que calcula IVA y total
        CalcularIVAyTotal(cantidad, precioUnitario);
    }

    // Función que calcula y muestra subtotal, IVA y total
    static void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
    {
        // Cálculo del subtotal
        decimal subtotal = cantidad * precioUnitario;

        // Cálculo del IVA (15%)
        decimal iva = subtotal * 0.15m;

        // Cálculo del total a pagar
        decimal total = subtotal + iva;

        // Muestra de resultados en consola
        Console.WriteLine($"\nCantidad: {cantidad}");
        Console.WriteLine($"Precio unitario: {precioUnitario:F2}");
        Console.WriteLine($"Subtotal: {subtotal:F2}");
        Console.WriteLine($"IVA (15%): {iva:F2}");
        Console.WriteLine($"Total a pagar: {total:F2}");
    }
}
