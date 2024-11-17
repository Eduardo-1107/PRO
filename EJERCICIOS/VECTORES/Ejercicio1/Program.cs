//Solicitar 10 números por teclado y calcular su media aritmética.
namespace VECTOR01;
class Program
{
    static void Main(string[] args)
    {
        double media = 0;
        int[] vector = new int[10];
        int cont = 0;
        int sum = 0;

        Console.WriteLine("Escribe 10 números: ");
        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = Convert.ToInt32(Console.ReadLine());
            cont++;
            sum += vector[i];
        }
        media = Convert.ToDouble(sum) / cont;
        Console.WriteLine($"La suma es: {sum} ");
        Console.WriteLine($"La media es: {media:f2} ");
    }
}


