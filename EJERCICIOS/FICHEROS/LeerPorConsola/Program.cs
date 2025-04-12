class Program
{
    static void Main(string[] args)
    {
        FileStream fs;
        StreamWriter sw ;
        try
        {
            using (fs = new FileStream("texto.txt",FileMode.Append))
            using (sw = new StreamWriter(fs)) 
            {
                int iLetra;
                char letra;
                while ((iLetra = Console.Read()) != '.' && iLetra != -1)  {
                letra = char.ToUpper((char)iLetra);
                sw.Write(letra);
                }
                sw.WriteLine()
                kughghjjhgfdxcbvcn
                
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("PROBLEMAS: " + e.Message);
        }
                
    }
}