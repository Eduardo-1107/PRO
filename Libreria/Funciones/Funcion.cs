/*                                                        
************************************************************

····· Libreria De Métodos y Funciones by Eduardo Armas ·····

************************************************************
*/

public class Funciones {

    //Búsqueda Lineal (IndexOf)
    public static int BLineal(string s, char ch) {
        int pos=0;
        if(s!=null) {
            while(pos<s.Length && s[pos] != ch)
                pos++;
            if (pos == s.Length)
                pos = -1; 
        }
        return pos; // Si devuleve menos 1 es que no se encontró
    }

    // Lee una cadena Escribiendo antes un mensaje (Controla si es vacío o no)
    public static string LeerCadena(string msg, bool? vacio = false) {
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

    // Lee un número (intervalo mínimo) (intervalo máximo)
    public static int LeerNum(string? msg, int? min = null, int? max = null) {
        int num;
        Console.WriteLine(msg);
        while (!int.TryParse(Console.ReadLine(), out num) || num < min || num > max)
            Console.WriteLine("Incorrecto, vuelva a intentarlo");
        return num;
    }

    //Renueva la consola
    public static void ClearConsola() {
        Console.WriteLine("\n\nPulse una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }

}  