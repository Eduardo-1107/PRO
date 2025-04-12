using System.IO;
public class Program {

    private const string NOMBRE_FICH="numeros.txt";

    public static void Main(string[] args) {        
        MostrarSimpaticos();
    }

    public static void MostraNum() {
        FileStream fs = new FileStream(NOMBRE_FICH, FileMode.Open);
        StreamReader sr = new StreamReader(fs);       
        string? linea;
        // linea = sr.ReadLine();        
        // while(linea!=null){           
        //     Console.WriteLine(linea);
        //     linea = sr.ReadLine();
        // }       
        while((linea = sr.ReadLine())!=null)
            Console.WriteLine(linea);
        sr.Close();
    }

    public static int SumarNum()
    {
        FileStream fs = new FileStream(NOMBRE_FICH, FileMode.Open);
        StreamReader sr = new StreamReader(fs);

        int acuNum = 0; 
        string? SumarNumLinea;

        SumarNumLinea = sr.ReadLine();
        while(SumarNumLinea!=null){             
            try{
                acuNum += Convert.ToInt32(SumarNumLinea);
            } catch(FormatException){}
            SumarNumLinea = sr.ReadLine();
        }       
        sr.Close(); 
        return acuNum;
    }
    public static int MostrarSimpaticos()
    {
        FileStream fs = new FileStream(NOMBRE_FICH, FileMode.Open);
        StreamReader sr = new StreamReader(fs);

        int acuNum = 0; 
        int num;
        NumeroSimpatico ns;
        string? linea;

        
        while((linea = sr.ReadLine())!=null){             
            try{
                num = Convert.ToInt32(linea);
                ns = new NumeroSimpatico();
                linea = linea.Trim();

                foreach (char dig in linea)
                {
                    ns.AddDigito(dig-'0');
                }
                if (ns.IsValido())
                    Console.WriteLine(num);
            } catch(FormatException){}  
        }       
        sr.Close(); 
        return acuNum;
    }
}