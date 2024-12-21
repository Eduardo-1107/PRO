/* 
Introducir por teclado una frase y a continuación visualizar cada palabra de la frase, 
una debajo de otra, seguida cada palabra del número de letras que compone dicha palabra.
*/
namespace STRING11;
class Program {
    static void Main(string[] args) {
        string frase, palabra;
        int i = 0;

        frase = Funciones.LeerCadena("Introduzca una frase: ");
        while (i < frase.Length) {
            palabra = "";
            while (i < frase.Length && frase[i] != ' ') {
                palabra += frase[i];
                i++;
            }
            Console.WriteLine($"{palabra} ({palabra.Length} letras)");
            i++;
        }
    }
}

class Funciones {
    public static string LeerCadena(string msg, bool vacio = false) {
        string s;
        if (vacio == true) {
            Console.Write(msg);
            s = Console.ReadLine() ?? "";
        } else 
            do {
                Console.Write(msg);
                s = Console.ReadLine() ?? "";
            } while (String.IsNullOrEmpty(s));
        return s;
    }  
}




