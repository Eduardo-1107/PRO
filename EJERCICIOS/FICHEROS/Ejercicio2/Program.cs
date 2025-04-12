class Program
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("texto.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string sLinea;
        int iNumero = 0;
        while ((sLinea = sr.ReadLine()) != null) {
            try {
                iNumero += Convert.ToInt32(sLinea);
            } catch (FormatException) {}
        }
        Console.WriteLine(iNumero);
        sr.Close();
    }
}
