// Dada una cadena por teclado, mostrar la cadena al revés.
namespace STRING03;

class Program {
    static void Main(string[] args) {
        string s1;

        Console.WriteLine("Escribe una cadena de texto por teclado");
        s1 = Console.ReadLine();

        for (int i = s1.Length - 1; i >= 0; i--) 
            Console.Write(s1[i]);
    }
}