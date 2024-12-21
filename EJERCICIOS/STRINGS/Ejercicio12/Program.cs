/* 
Desarrolla un programa que devuelva una cadena con un carácter repetido n veces, siendo n solicitado por teclado.
*/
namespace STRING12;
class Program {
    static void Main(string[] args) {
        const string S = "Hola.";
        string sM;
        char ch;
        int num;
        
        Console.WriteLine($"La cadena es: \"{S}\".");
        ch =Funciones.LeerChar("Escribe un carácter que quieres que se repita: ");
        Funciones.LeerNum("¿Cuántas veces quieres que se repita? --> ");

        for (int i = 0; i < S.Length; i++) {
            if (S[i] == ch) {
            }
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
    public static char LeerChar(string msg) {
        char ch;
        Console.Write(msg);
        while(!char.TryParse(Console.ReadLine(), out ch))
            Console.WriteLine("Incorrecto, vuelva a intentarlo");
        return ch;
    }
    public static int LeerNum(string? msg, int? min = null, int? max = null) {
        int num;
        Console.WriteLine(msg);
        while (!int.TryParse(Console.ReadLine(), out num) || num < min || num > max)
            Console.WriteLine("Incorrecto, vuelva a intentarlo");
        return num;
    }
}





