// Dada una cadena por teclado, introducir en una nueva variable la cadena al revés, y mostrarla.
namespace STRING04;
class Program {
    static void Main(string[] args) {
        string s1,sReves="";

        Console.WriteLine("Escribe una cadena de texto por teclado");
        s1 = Console.ReadLine();

        for (int i = s1.Length - 1; i >= 0; i--) 
            sReves += s1[i];
        Console.WriteLine(sReves);
    }
}
