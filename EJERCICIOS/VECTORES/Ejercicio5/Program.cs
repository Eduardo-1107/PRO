/* Crear un programa que pida al usuario 10 números decimales, calcule su media y luego muestre los que están por encima de la media. */
namespace VECTOR05;
class Program {
    static void Main(string[] args) {
        int cont = 10;
        double media, suma=0;
        double[] datos = new double[10];
        double[] datosEncimaMedia = new double[10];
        Console.WriteLine("Escribe 10 números (pueden ser decimales)");
        for (int i  = 0; i < datos.Length;i++) {
            Console.Write($"Número {i+1}: ");
            datos[i] = Convert.ToDouble(Console.ReadLine());
            suma += datos[i];
        }
        media = suma / cont;
        Console.WriteLine($"La media es: {media:f2} ");
        Console.WriteLine("Los datos por encima de la media son: ");
        for (int i = 0; i < datos.Length;i++) 
            if (datos[i] > media)
                Console.WriteLine($"{datos[i]}"); 
    }
}