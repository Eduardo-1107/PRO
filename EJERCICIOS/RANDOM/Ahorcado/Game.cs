namespace AHORCADO;
public class Game
{
    // Lee la palabra secreta e inicializa el array de aciertos.
    public static void LeerSecreto(out char[] cadenaAciertos, out string cadenaSecreta) {
        cadenaSecreta = Funcion.LeerCadena();
        cadenaSecreta.Trim();
        cadenaAciertos = new char[cadenaSecreta.Length];
        cadenaAciertos = cadenaSecreta.ToCharArray();
    }
    // Muestra la palabra secreta, revelando las letras acertadas y ocultando el resto con guiones bajos. 
    public static string EscribirSecreto( ref char[] cadenaAciertos, char[] letrasUtilizadas) {
        string cadenaFinal = "";
        foreach (char caracter in cadenaAciertos)
        {
            if (caracter == ' ')
                cadenaFinal += ' ';
            else if (Array.Exists(letrasUtilizadas, letras => letras == caracter))
                cadenaFinal += caracter;
            else
                cadenaFinal += '_';
        }
        return cadenaFinal;
    }
    //Dibuja el estado actual del ahorcado según el número de fallos.
    public static void MostrarAhorcado(int numeroFallos) {
        switch (numeroFallos) {
        case 0:
            Console.WriteLine("  _______");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine("/|\\\n\n");
            break;
        case 1:
            Console.WriteLine("  _______");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |      O");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine("/|\\\n\n");
            break;
        case 2:
            Console.WriteLine("  _______");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |      O");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine("/|\\\n\n");
            break;
        case 3:
            Console.WriteLine("  _______");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |      O");
            Console.WriteLine(" |     /|");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine("/|\\\n\n");
            break;
        case 4:
            Console.WriteLine("  _______");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |      O");
            Console.WriteLine(" |     /|\\");
            Console.WriteLine(" |       ");
            Console.WriteLine(" |       ");
            Console.WriteLine("/|\\\n\n");
            break;
        case 5:
            Console.WriteLine("  _______");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |      O");
            Console.WriteLine(" |     /|\\");
            Console.WriteLine(" |     / ");
            Console.WriteLine(" |       ");
            Console.WriteLine("/|\\\n\n");
            break;
        case 6:
            Console.WriteLine("  _______");
            Console.WriteLine(" |      |");
            Console.WriteLine(" |      O");
            Console.WriteLine(" |     /|\\");
            Console.WriteLine(" |     / \\");
            Console.WriteLine(" |       ");
            Console.WriteLine("/|\\\n\n");
            break;
        }
    }
    //Lee una letra introducida por el jugador y la añade a la lista de letras utilizadas.
    public static void LeerLetra(ref char[] letrasUtilizadas, int posicion) {
        letrasUtilizadas[posicion] = Funcion.LeerCaracterSinBuffer();
    }
    // Cuenta el número de letras acertadas.
        /* public static int NumeroAciertos() {
        } */
   
}