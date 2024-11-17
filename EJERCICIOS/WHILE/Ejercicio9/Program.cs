// Solicitados cinco números por teclado, calcular cuál es el de mayor valor y cuál el de menor y mostrarlos por pantalla.
namespace WHILE09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numMax=-2147483647,numMin=2147483647,i=0;
            Console.WriteLine("Escribe 5 números");
            while (i < 5)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < numMin)
                    numMin = num;
                if (num > numMax)
                    numMax = num;
                i++;
            }
            Console.Clear();
            Console.WriteLine("El número mínimo es: " + numMin);
            Console.WriteLine("El número máximo es: " + numMax);
        }
    }
}