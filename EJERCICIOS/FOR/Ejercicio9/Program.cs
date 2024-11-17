//Dados dos números, contar desde el primero al segundo número siempre que se pueda.
namespace FOR09 {
    class Program {
        static void Main(string[] args) {
            int num1,num2;
            Console.WriteLine("A continuación debes escribir dos números, se contarán los números que hay entre medias");
            Console.WriteLine("Primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2) 
                Console.WriteLine("No hay números entre los datos que escribiste");
            else
                for (; num1 <= num2; num1++)
                    Console.Write("\t" + num1);
        }
    }
}
