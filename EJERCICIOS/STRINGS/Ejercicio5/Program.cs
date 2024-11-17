// Dada una cadena por teclado, indicar cuáles son las vocales que contiene.
namespace STRING05;
class Program {
    static void Main(string[] args) {
        string s1, s2;
        char[] VOCAL = ['a', 'e', 'i', 'o', 'u'];
        int cont = 0;

        Console.WriteLine("Escribe una cadena de texto por teclado");
        s1 = Console.ReadLine();
        s2 = s1.ToLower();

        for (int i = 0; i < VOCAL.Length; i++) {
            for (int j = 0; j < s2.Length;j++)
                if (VOCAL[i] == s2[j])
                    cont++;
            Console.WriteLine($"Vocal {VOCAL[i]}: {cont}");
            cont = 0;
        }
    }
}

