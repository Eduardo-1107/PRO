//Presentar por pantalla los números que hay desde el 1 hasta un número solicitado por teclado.
namespace WHILE07
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int numFinal;
            Console.WriteLine("Tecleé un número, el programa mostrará los números del 1 al número indicado por usted.");
            numFinal = Convert.ToInt32(Console.ReadLine());
            while (num <= numFinal) {
                Console.Write(num + " ");
                num++;
            }
        }
    }
}