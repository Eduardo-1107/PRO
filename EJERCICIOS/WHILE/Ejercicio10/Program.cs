//Dados dos números introducidos por teclado, mostrar los números naturales que hay entre ambos.
namespace WHILE10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInicio,numFinal,i;

            Console.WriteLine("Escribe el inicio del número");
            numInicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el final del número");
            numFinal = Convert.ToInt32(Console.ReadLine());
            i = numInicio++;
            while (i < numFinal){
                Console.Write(++numInicio + " ");
                ++i;
            }
        }
    }
}
