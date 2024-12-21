/*  
    Comprobar si un número es primo utilizando recursividad.
*/
namespace FUNCIONES05;
class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Funciones
{
    public static bool EsPrimo (int numero) {
       
       int i = 2;
        while (i < numero && numero % i != 0) 
            i++;
        return i == numero;
    }
}
