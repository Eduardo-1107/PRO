// Solicitada una frase y una letra, encontrar el número de veces que dicha letra aparece en la frase dada.
namespace STRING02;

class Program {
    static void Main(string[] args) {
        string? s1;
        char letra;
        int cont = 0;

        Console.WriteLine("Escribe una frase: ");
        s1 = Console.ReadLine();
        Console.WriteLine("Escribe una letra");
        letra = (char)Console.Read();

        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] == letra)
            cont++;
        }
        Console.WriteLine($"En la frase \"{s1}\" se ha encontrado la letra \"{letra}\" {cont} veces.");
    }
}