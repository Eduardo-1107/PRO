//Solicitar 10 números distintos por teclado y mostrarlos.
using System.ComponentModel;
using System.Reflection.Metadata;

namespace VECTOR03;
class Program
{
    static void Main(string[] args)
    {
        int[] vector = new int[10];
        int pos;
        int i = 0;
        int num;
        Console.WriteLine("Escribe 10 números:");
        Console.Write("Número 1: ");
        vector[0] = Convert.ToInt32(Console.ReadLine());

        for (pos = 1; pos < vector.Length; pos++)
        {
            do
            {
                Console.Write($"\nNúmero {pos + 1}: ");
                num = Convert.ToInt32(Console.ReadLine());
                i = 0; //Inicalizar búsqueda
                while ((i < pos - 1) && (vector[i] != num)) //Mientras (queden datos entre los "pos" números que llevo leidos y no encontrado lo que busco)
                    i++;
            } while (vector[i] == num); //Mientras encontrado el número entre los dos leídos hasta el momento
            vector[pos] = num;
        }
        Console.WriteLine();
        for (int j = 0; j < vector.Length; j++)
            Console.WriteLine(vector[j]);
    }
}