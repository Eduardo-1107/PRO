/* Solicitar una cantidad no definida de datos y calcular su suma. 
Debe estar preparado para un máximo de 100 números, que pedirá de uno en uno. 
Cuando se introduzca un valor cero, mostrará la suma de todos los anteriores y dará el número de datos introducidos. */
using System.Globalization;

namespace VECTOR04;
class Program {
    static void Main(string[] args) {
        int num, suma = 0, cont = 0;
        int[] datos = new int[100];
        bool noSalir = true;

        // Es mejor hacer lectura anticipada
        
        Console.WriteLine("Introduce números hasta introducir 0, el máximo de números es 100");
        for (int i = 0; (i < datos.Length) && (noSalir == true); i++) {
            Console.Write($"Número {i + 1}: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                noSalir = false;
            else {
                datos[i] = num;
                suma += datos[i];
                cont++;
            }
        }
        Console.WriteLine($"El número de datos introducidos es: {cont}");
        Console.WriteLine($"La suma de datos introducidos es: {suma}");
    }
}
