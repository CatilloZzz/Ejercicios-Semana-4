// Ejercicio 9: Validar contraseña
// Este programa valida si una contraseña cumple con ciertos requisitos. - Tiene al menos 8 caracteres.
//- Contiene al menos una letra mayúscula.
//- Contiene al menos un número.

class Program
{
    // Función que valida si la contraseña cumple los requisitos
    static bool EsContrasenaSegura(string contrasena)
    {
        // Debe tener al menos 8 caracteres
        if (contrasena.Length < 8)
            return false;

        bool tieneMayuscula = false;
        bool tieneNumero = false;

        // Recorre cada caracter de la contraseña
        foreach (char c in contrasena)
        {
            // Verifica si hay una letra mayúscula
            if (c >= 'A' && c <= 'Z')
                tieneMayuscula = true;
            // Verifica si hay un número
            if (c >= '0' && c <= '9')
                tieneNumero = true;
        }

        // Retorna true solo si tiene mayúscula y número
        return tieneMayuscula && tieneNumero;
    }

    static void Main()
    {
        // Pide al usuario que ingrese una contraseña
        Console.Write("Ingrese una contraseña: ");
        string pass = Console.ReadLine();

        // Llama a la función y muestra el resultado
        if (EsContrasenaSegura(pass))
            Console.WriteLine("Contraseña válida.");
        else
            Console.WriteLine("Contraseña inválida.");
    }
}