//Presenta por pantalla los números pares del 1 al 100.
namespace WHILE03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 100)
            {
                if (num % 2 == 0)
                    Console.Write(num + " ");
                num++;
            }
        }
    }
}