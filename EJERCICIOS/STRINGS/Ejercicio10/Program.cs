/* Dada una frase y una palabra, eliminar esa palabra de la frase tantas veces como aparezca, 
diciendo la frase sin ellas y el número de veces que se ha eliminado. Por ejemplo: dada la frase:
“Hola amigo. Como estas amigo. Yo estoy muy bien amigo.”, y la palabra “amigo”,
debe devolver: “Hola. Como estas. Yo estoy muy bien.” y mostrar el valor 3, por eliminarlo tres veces. 
Se debe eliminar la palabra, y el espacio en blanco anterior si lo hubiera.
*/
namespace STRING10;
class Program {
    static void Main(string[] args) {
        string frase;
        string palabra;
        int contador = 0;
        int i = 0;
        int j = 0;
        string nuevafrase = "";

        frase = Funciones.LeerCadena("Introduzca una frase: ");
        palabra = Funciones.LeerCadena("Introduzca una palabra: ");

        while (i <= frase.Length - palabra.Length) {
            j = 0;
            while (j < palabra.Length && frase[i + j] == palabra[j])
                j++;
            if (j == palabra.Length) {
                contador++;
                i += palabra.Length; 
                if (i < frase.Length && (frase[i] == ' ' || frase[i] == '.' || frase[i] == ','))
                    while (i < frase.Length && frase[i] == ' ')
                        i++;
            }
            else {
                nuevafrase += frase[i];
                i++;
            }
        }
        while (i < frase.Length) {
            nuevafrase += frase[i];
            i++;
        }

        Console.WriteLine("La nueva frase es: " + nuevafrase);
        Console.WriteLine($"Se ha eliminado: {contador} veces");
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



