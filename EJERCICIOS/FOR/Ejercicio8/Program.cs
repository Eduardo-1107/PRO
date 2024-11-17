// Dado un número entero, calcular todos sus divisores.
namespace FOR08 {
    class Program {
        static void Main(string[] args) {
            int num, cont = 1;
            Console.WriteLine("Escribe un número entero.");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                Console.WriteLine("Todos los números son divisores de 0");
            else
                for (int i = 1; i <= num; i++ ) {
                    if (num % i == 0) {
                        Console.WriteLine($"\n[{cont}] {i} es divisor de {num}\n");
                        ++cont;
                    }
                }
        }
    }
}
