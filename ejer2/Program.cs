// Ejercicio 2: Intercambiar valores 
// Este programa intercambia los valores de dos variables usando un método.

// Definición de la clase principal del programa
class Program
{
    // Método principal: punto de entrada del programa
    static void Main()
    {
    int a = 5; // Declaración e inicialización de la variable a
    int b = 10; // Declaración e inicialización de la variable b

    // Muestra los valores antes del intercambio
    Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");
    // Llama al método para intercambiar los valores de a y b
    Intercambiar(ref a, ref b);
    // Muestra los valores después del intercambio
    Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
    }

    // Método que intercambia los valores de dos variables usando referencias
    static void Intercambiar(ref int x, ref int y)
    {
    int temp = x; // Guarda el valor de x en una variable temporal
    x = y;        // Asigna el valor de y a x
    y = temp;     // Asigna el valor guardado en temp a y
    }
}
// Antes del intercambio: a = 5, b = 10
// Después del intercambio: a = 10, b = 5