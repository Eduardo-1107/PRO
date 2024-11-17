/* Dada una cadena por teclado, y una segunda de comparación, 
** mostrar por pantalla la cadena “Está” cuando encontremos la segunda cadena en cualquier posición de la primera. 
*/
namespace STRING07;
class Program {
    static void Main(string[] args) {
       string s1,s2;
       int desde = 0, i,j;
       bool esta;


       s1 = Funciones.LeerCadena("Escribe un texto (no puede estar vacío): ");
       s2 = Funciones.LeerCadena("Escribe un segundo texto a modo de comparación (no puede estar vacío): ");


       do {
        i = desde;
        j = 0;
        while (s1[i] == s1[j] && i < s1.Length && j < s2.Length) {
            i++;
            j++;
        }
        desde++;
        esta = j == s2.Length;
       } while (desde <= s1.Length - s2.Length && !esta); //determina donde empieza cada palabra mientras no se haya encontrado la palabra
       if (esta) 
        Console.WriteLine("Está");
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


