// Dada una cadena de caracteres introducida por teclado, contar el número de caracteres que la componen.
namespace STRING01;

class Program {
    static void Main(string[] args) {
        string s1;

        Console.Write("Escribe una cadena de carácteres: ");
        s1 = Console.ReadLine();

        Console.WriteLine($"Nº Carácteres: {s1.Length}");
    }
}