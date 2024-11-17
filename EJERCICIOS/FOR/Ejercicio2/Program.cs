//Pide por teclado cinco números y muestra su suma.
namespace FOR02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Teclea 5 números:");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("La suma es: " + sum);
        }
    }
}
