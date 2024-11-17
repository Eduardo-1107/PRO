// Dado un número por teclado, mostrar su tabla de multiplicar.
namespace FOR07 {
    class Program {
        static void Main(string[] args) {
            int num,FIN_TABLA = 10;
            Console.WriteLine("Escribe un número y se mostrará su tabla de multiplicar.\n");
            num = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("\n--------------------------------\n");
            for (int i = 0; i <= FIN_TABLA;i++) 
                Console.WriteLine($"\t{num} x {i,3} = {num*i,4}");
        }
    }
}
