namespace AHORCADO;
public class Funcion
{
    public static void BorrarPantalla() {
        Console.WriteLine("\n\nPulse una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
    public static string LeerCadena() {
        string s; 
            do {
                s = Console.ReadLine() ?? "";
            } while (String.IsNullOrEmpty(s));
        return s;
    }
    public static char LeerCaracterSinBuffer() => Console.ReadKey(true).KeyChar;
    public static int LeerEnteroSinBuffer() => Console.ReadKey(true).KeyChar;  
}