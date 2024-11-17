/* Teniendo en cuenta que la clave es “eureka”, escribir un algoritmo que nos pida una clave. 
** Solo tenemos 3 intentos para acertar, si fallamos los 3 intentos nos mostrara un mensaje indicándonos que hemos agotado esos 3 intentos. 
** Si acertamos la clave, saldremos directamente del programa. 
*/
namespace STRING08;
class Program {
    static void Main(string[] args) {
       const string CLAVE = "eureka";
       string intentoClave; 
       int intentos = 3;

       do
       {
        intentoClave = Funciones.LeerCadena($"Escribe la clave (Intentos: {intentos}) --> ");
        intentos--;
       } while (intentoClave != CLAVE && intentos > 0 );
       if (intentos == 0 && intentoClave != CLAVE)
        Console.WriteLine("Has agotado los tres intentos");
       else
        Console.WriteLine("Felicidaes accediste correctamente");
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



