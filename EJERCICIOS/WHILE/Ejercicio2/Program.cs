//Presenta por pantalla los números del 100 al 0
namespace WHILE02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            while (num >= 0)
            {
                Console.Write(num + " ");
                num--;
            }
        }
    }
}
