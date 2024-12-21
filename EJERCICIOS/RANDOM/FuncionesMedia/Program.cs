namespace FuncionesMedia;
class Program
{
    static void Main(string[] args)
    {
        double[] numeros = new double[10];
        double media;
        Console.WriteLine("Primera forma: ");
        Funciones.LeerVector(numeros,"Escribe 10 números");
        Console.WriteLine($"La media es: {Matematicas.Media(numeros):f2}");
        Funciones.BorrarPantalla();
        Console.WriteLine("Segunda forma: ");
        Matematicas.Media(numeros, out media);
        Console.WriteLine($"La media es: {media:f2}");
    }
}

class Funciones
{
    public static double[] LeerVector(double[] vector, string msg) {
        Console.WriteLine(msg);
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Valor {i+1}: ");
            while (!double.TryParse(Console.ReadLine(), out vector[i]))
                Console.WriteLine("Incorrecto, vuelva a intentarlo");
        }
        return vector;
    }
    public static void BorrarPantalla() {
        Console.WriteLine("\n\nPulse una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
}