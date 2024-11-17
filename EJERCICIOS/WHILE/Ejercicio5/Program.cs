//Incluir en algoritmo anterior las suma de cuántos números impares se muestran.
namespace WHILE05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            Console.WriteLine("Introduce un número menor que 100");
            num = Convert.ToInt32(Console.ReadLine());
            while (num <= 100)
            {
                if (!(num % 2 == 0)) {
                    Console.Write(num + " ");
                    sum+=num;
                }
                num++;
            }
            Console.WriteLine($"\nLa suma de todos los números impares a partir del número introducido es: {sum}");
        }
    }
}