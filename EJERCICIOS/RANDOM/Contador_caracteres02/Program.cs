namespace Contar_caracteres_SinBuffer_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char caracter = ' ';
            int contador = 0;
            Console.WriteLine("Introduce caracteres");
            caracter = Console.ReadKey().KeyChar;
            while (caracter != '.') {
                if (caracter == '\b')
                {
                    contador--;
                    Console.Write(" \b");
                } else {
                    contador++;
                    if (caracter == '\r')
                        Console.Write("\n");
                }
                caracter = Console.ReadKey().KeyChar;  
                
            }
            Console.WriteLine($"\nHas introducido {contador} caracteres \u2764");
        }
    }
}