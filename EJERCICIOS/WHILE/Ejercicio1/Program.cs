//Presenta por pantalla los números del uno al 100 
namespace WHILE01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 100)
            {
                Console.Write(num + " ");
                num++;
            }
        }
    }
}