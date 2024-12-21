using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;

namespace AHORCADO;
public class Menu
{
    public static void VerMenu(int num) {
        switch (num)
        {
            case 0:
                Menu0();
                break;
            case 1:
                Menu1();
                break;
            case 2:
                Menu2();
                break;
        }
    }
    private static void Menu0() {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------------\n\n");
        Console.WriteLine("\t\t *BIENVENIDO/A AL AHORCADO* \n");
        Console.WriteLine("\t\t ¿Qué desea hacer?");
        Console.WriteLine("\t\t 1. Jugar.");
        Console.WriteLine("\t\t 0. Salir.");
        Console.WriteLine("\n\n---------------------------------------------------------------");
    }
    private static void Menu1() {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------------\n\n");
        Console.WriteLine("\t\t 1. *JUGAR* \n");
        Console.WriteLine("\t\t ¿Qué modo de juego desea jugar?");
        Console.WriteLine("\t\t 1. Personalizado (Elige tú) ");
        Console.WriteLine("\t\t 2. Elegir modalidad predefinida");
        Console.WriteLine("\t\t 0. Atrás.");
        Console.WriteLine("\n\n---------------------------------------------------------------");
    }
    private static void Menu2() {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------------\n\n");
        Console.WriteLine("\t\t *MODO DE JUEGO PERSONALIZADO* \n");
        Console.WriteLine("\t\tEscribe una palabra o una frase\n\t\tpara jugar al ahorcado con ella");
        Console.WriteLine("\n\n---------------------------------------------------------------");
    }
    public static int LeerOpcion(string sMsg) {
        int iNum;
        Console.Write(sMsg); 
        iNum = Funcion.LeerEnteroSinBuffer();
        return iNum;
    }
 
}