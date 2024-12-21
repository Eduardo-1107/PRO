/*
    Implementa un programa Secuencias que lea de teclado 20 números enteros
    (distintos de cero) y después de leídos, los muestre por la salida estándar
    (pantalla).... comenzando con una nueva línea cada vez que la secuencia
    de números (en valor absoluto) sume más de 100.
    Al final de cada línea debe mostrarse (entre barras) la suma absoluta de la línea.
*/

namespace Secuencias;
class Program {
    static void Main(string[] args) {
        int iSuma = 0, j=0;
        int[] iNumeros = new int[20]; 
        for (int i = 0; i < iNumeros.Length; i++)   
            while ((iNumeros[i] = Funciones.LeerNum($"Escribe el número {i+1}: ")) == 0)
                Console.WriteLine("Introduciste valor cero, vuelva a intentarlo.");
        while ( j < iNumeros.Length) {
            iSuma = 0;
            while (iSuma < 100 && j < iNumeros.Length) {
                iSuma += Math.Abs(iNumeros[j]);
                Console.Write(iNumeros[j] + " ");
                j++;
            }
            Console.Write($"\\{iSuma}\\\n");
        }
    }
}

class Funciones {
    public static int LeerNum(string? msg) {
        int num;
        Console.WriteLine(msg);
        while (!int.TryParse(Console.ReadLine(), out num))
            Console.WriteLine("Incorrecto, vuelva a intentarlo");
        return num;
    }
}