/*  Realizar el mismo ejercicio anterior, pero al pasar a la función los grados Celcius, 
    también se le pasará una “F” para pasar a grados Fahrenheit, 
    o una “K” para pasar a grados Kelvin. 
*/
namespace FUNCIONES02;
class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Funciones
{
    public static double AOtraEscala (double celcius, char escala) {
        double solucion;
        if (escala == 'K')
            solucion = 273.15 + celcius;
        else if (escala == 'F')
            solucion = 1.8 * celcius + 32;
        else 
            throw new ArgumentException("La escala solicitada sólo puede ser \"F\" o \"K\"");
        return solucion;
    }
}