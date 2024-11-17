//Escriba un programa que pida dos números enteros y escriba la suma de todos los enteros desde el primer número hasta el segundo.
//Corregido
namespace FOR10 {
    class Program {
        static void Main(string[] args) {
            int num1,num2,sum=0,aux;

            Console.Write("Introduce un número entero: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un número entero: ");
            num2=Convert.ToInt32(Console.ReadLine());
            if (num1>num2) {
                aux=num1;
                num1=num2;
                num2=aux;
            }
            for (; num1 <= num2; num1++)
                sum += num1;
            Console.WriteLine("La suma es: " + sum);
        }
    }
} 