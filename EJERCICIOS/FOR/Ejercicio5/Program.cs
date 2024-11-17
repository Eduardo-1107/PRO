// Presenta por pantalla las suma de los número del 1 al 100.
namespace FOR05 {
    class Program {
        static void Main(string[] args) {
            int sum=0;
            for (int i = 1; i <= 100; i++)
                Console.Write((sum+=i) + " ");

        }
    }
}
