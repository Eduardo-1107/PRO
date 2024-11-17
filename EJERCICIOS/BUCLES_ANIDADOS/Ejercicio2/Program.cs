//Mostrar por pantalla los números del 1 al 100, colocando 10 números en cada fila a mostrar.
namespace BUCLEANIDADO02;

class Program {
    static void Main(string[] args) {
        int contador = 1;
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                Console.Write($"{contador,3} ");
                contador++;
            }
            Console.WriteLine();
        }

    }
}