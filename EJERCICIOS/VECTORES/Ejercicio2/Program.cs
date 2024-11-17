//Solicitar 10 números por teclado. A continuación, solicitar otro. 
//Buscar ese último número entre los 10 primeros y decir, en el caso de que esté, en qué lugar fue introducido.
namespace VECTOR02;
class Program
{
    static void Main(string[] args)
    {
        int num;
        int[] vector = new int[10];
        int cont = 0;

        Console.WriteLine("Escribe 10 números: ");
        for (int i = 0; i < vector.Length; i++)
            vector[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe otro número: ");
        num = Convert.ToInt32(Console.ReadLine());
        while ((cont < (vector.Length - 1)) && (num != vector[cont]))
            cont++;
        if (num == vector[cont])
            Console.WriteLine($"{num} encontrado en la posición {++cont}");
        else
            Console.WriteLine($"No se encuentra {num}");
    }
}
