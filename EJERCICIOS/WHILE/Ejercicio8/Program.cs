//Imprimir y contar el número de múltiplos de tres que existen desde el 1 a un número solicitado por teclado.
namespace WHILE08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num = 1, numFinal;

            Console.WriteLine("Introduce un número por teclado, Se contarán y se imprimiran los múltiplos de 3 desde el 1 hasta el número indicado");
            numFinal = Convert.ToInt32(Console.ReadLine());
            while (num <= numFinal)
            {
                if (num % 3 == 0){
                    Console.Write(num + " ");
                    i++;    
                }
                num++;    
            }
            Console.WriteLine($"\nDel 1 al {numFinal} hay {i} múltiplos de 3.");
        }
    }
}
