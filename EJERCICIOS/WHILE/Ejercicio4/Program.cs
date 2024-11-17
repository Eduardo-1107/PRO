//Dado un número introducido por teclado que debe ser menor que 100, presentar todos los números impares que van desde él hasta el 100.
namespace WHILE04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introduce un número menor que 100");
            num = Convert.ToInt32(Console.ReadLine());
            while (num <= 100)
            {
                if (!(num % 2 == 0))
                    Console.Write(num + " ");
                num++;
            }
        }
    }
}