using System; 

class Program
{
    // Procedimiento para mostrar la tabla de multiplicar
    // Este método recibe dos parámetros por valor:
    //   numero: el número del cual se genera la tabla
    //   limite: hasta qué número se multiplica
    static void MostrarTabla(int numero, int limite)
    {
        // Ciclo desde 1 hasta el límite indicado por el usuario
        for (int i = 1; i <= limite; i++)
        {
            // Muestra el resultado de la multiplicación en pantalla
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    static void Main(string[] args)
    {
        // Solicita al usuario el número para la tabla de multiplicar
        Console.Write("Ingresa el número para la tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine()); // Convierte la entrada a entero

        // Solicita al usuario el número límite hasta donde se multiplicará
        Console.Write("Ingresa el número límite: ");
        int limite = int.Parse(Console.ReadLine()); // Convierte la entrada a entero

        // Llama al procedimiento para mostrar la tabla de multiplicar
        MostrarTabla(numero, limite);
    }
}

