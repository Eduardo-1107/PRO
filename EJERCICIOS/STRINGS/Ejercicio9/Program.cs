/* Dada una cadena de caracteres que contenga el nombre de una persona en formato "APELLIDOS, NOMBRE",
convertirla en una cadena del tipo NOMBRE APELLIDOS.
*/
namespace STRING09;
class Program {
    static void Main(string[] args) {
        string formatoI, nombre = "",  apellidos = "";
        bool coma = false;
        formatoI = Funciones.LeerCadena("Introduzca su nombre y apellidos en el siguiente formato (APELLIDOS, NOMBRE) --> ");
        for (int i = 0; i < formatoI.Length;i++) {
            if (formatoI[i] == ',') {
                coma = true;
                i += 2;
            }
            if (coma == true)
                nombre += formatoI[i];
            else 
                apellidos += formatoI[i];
        }
        Console.WriteLine(nombre + " " + apellidos);
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



