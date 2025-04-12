
class Program
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("texto.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string numero;
        while ((numero = sr.ReadLine()) != null)
            Console.WriteLine(numero);
        sr.Close();
    }
}