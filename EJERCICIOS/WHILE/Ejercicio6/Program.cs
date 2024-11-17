//Pide números por teclado, hasta que sumen 50 o más.
namespace WHILE06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int NUM_FINAL = 50;
            int sum = 0;
            Console.WriteLine("Teclea números, el programa finalizará cuando se hayan sumado 50 o más");
            while (sum < NUM_FINAL) {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
          Console.WriteLine($"La suma es {sum}");
        }
    }
}
