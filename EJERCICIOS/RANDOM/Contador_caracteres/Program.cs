class Program
{
    static void Main()
    {
        //Contar caracteres hasta que se introduzca "."
        int contador = 0;
        char caracter = ' ';
        Console.WriteLine("Introduce caracteres: ");
        caracter = Console.ReadKey().KeyChar;
        while (caracter != '.') {
            contador++;
            caracter = Console.ReadKey().KeyChar;
        }
        Console.WriteLine($"Has introducido {contador} carácteres");
    }
}
