//Comprobar que un número introducido por teclado es primo y que que es mayor que 1.
namespace BUCLEANIDADOPROPUESTO01;

class Program {
    static void Main(string[] args) {
        int num;
        bool esPrimo = true;
        Console.Write("Introduce un número por teclado: ");
        if (int.TryParse(Console.ReadLine(), out num) && (num > 1)) {
            for (int i = 2; i <= num; i++) 
                for (int j = 2; j < num; j++)
                    if (num % j == 0)
                        esPrimo = false;
            if (esPrimo) 
                Console.WriteLine($"El número {num} es primo y mayor que uno");
            else
                Console.WriteLine($"El número {num} no es primo y es mayor que 1");
        } else 
            Console.WriteLine("Incorrecto vuelva a comenzar");
    }
}

