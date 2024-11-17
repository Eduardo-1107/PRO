//Leer números enteros hasta teclear cero, y nos muestre el máximo, el mínimo y la media de todos ellos.
namespace WHILE11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,nMax=int.MinValue,nMin=int.MaxValue,i=0,nSum=0;
            double nMed;

            Console.WriteLine("Escribe números hasta teclear 0");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0) {
                if (num < nMin)
                    nMin = num;
                if (num > nMax)
                    nMax = num;
                nSum+=num;
                i++;
                Console.WriteLine("Escribe números hasta teclear 0");
                num = Convert.ToInt32(Console.ReadLine());
            }
            nMed = Convert.ToDouble(nSum) / i;
            Console.WriteLine($"\n\nEl número mínimo es: {nMin}");
            Console.WriteLine($"El número máximo es: {nMax}");
            Console.WriteLine($"La media es: {nMed:f2}");
        }
    }
}
