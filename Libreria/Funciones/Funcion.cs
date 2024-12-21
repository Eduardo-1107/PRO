/*                                                        
************************************************************

····· Libreria De Métodos y Funciones by Eduardo Armas ·····

************************************************************
*/

using System.Runtime.Intrinsics.Arm;

public class Funciones {

//Búsqueda Lineal (IndexOf)
    public static int bLineal(string texto, char ch){
        int pos;
        if(texto == null || texto.Length == 0 )
            pos = -1;
        else {
            pos=0;
            while(pos < texto.Length-1 & texto[pos]!=ch)
                pos++;
            if(texto[pos]!=ch)
                pos=-1; //Si devuelve -1 es que no encontró la letra 
        }
        //FINAL
        return pos; 
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

    public static char LeerChar(string msg) {
        char ch;
        Console.WriteLine(msg);
        while(!char.TryParse(Console.ReadLine(), out ch))
            Console.WriteLine("Incorrecto, vuelva a intentarlo");
        return ch;
    }
    // Lee vectores 
    public static double[] LeerVector(double[] vector, string msg) {
        Console.WriteLine(msg);
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Valor {i+1}: ");
            while (!double.TryParse(Console.ReadLine(), out vector[i]))
                Console.WriteLine("Incorrecto, vuelva a intentarlo");
        }
        return vector;
    }

    //Renueva la consola
    public static void BorrarPantalla() {
        Console.WriteLine("\n\nPulse una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }

}  