// Para los números del 1 al 100, calcular la suma de todos, la suma de los pares y la suma de los múltiplos de tres.
namespace FOR06;
    class Program {
        static void Main(string[] args) {
            int sumTodos=0, sumPares=0, sumMultTres=0;
            for (int i = 1; i <= 100; i++) {
                sumTodos+=i;
                if (i % 2 == 0)
                    sumPares+=i;
                if (i % 3 == 0)
                    sumMultTres += i;
            }
            Console.WriteLine($"Suma todos los números: {sumTodos}");
            Console.WriteLine($"Suma todos los números pares: {sumPares}");
            Console.WriteLine($"Suma todos los números múltiplos de tres: {sumMultTres}");
        }
    }

