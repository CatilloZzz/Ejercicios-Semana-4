// See https://aka.ms/new-console-template for more information

//Calcular el area de un triángulo
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la base del triángulo:");
        double baseT = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triángulo:");
        double altura = Convert.ToDouble(Console.ReadLine());

        double areaTriangulo = (baseT * altura) / 2;

        Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
    }

    static double CalcularAreaTriangulo(double baseT, double altura)
    {
        return (baseT * altura) / 2;
    }
}