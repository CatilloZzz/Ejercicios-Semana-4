using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero = int.Parse(Console.ReadLine());
        
        if (EsPar(numero))
        {
            Console.WriteLine($"{numero} es par.");
        }
        else
        {
            Console.WriteLine($"{numero} es impar.");
        }
    }


    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}

