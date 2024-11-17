//Imprimir 10 veces la serie de números del 1 al 30 en una misma línea.
namespace BUCLEANIDADO01;

class Program {
    static void Main(string[] args) {
        for (int i = 0; i <= 10; i++ ) {
            for (int j = 1; j <= 30;j++)
                Console.Write($"{j} ");
        } 
    }

}
