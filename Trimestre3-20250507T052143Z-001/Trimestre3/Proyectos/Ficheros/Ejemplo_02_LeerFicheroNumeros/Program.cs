using System.IO;
public class Program {

    private const string NOMBRE_FICH_ENTRA="numeros.txt";
    private const string NOMBRE_FICH_SALE="numeros.err";
    public static void Main(string[] args) {        
            //MostraNum();
            //Console.WriteLine($"La suma total es: {SumarNum()}");
            //Console.WriteLine($"La suma total es: {SumarNum2()}");
            Console.WriteLine($"La suma total es: {SumarNum3()}");
            //Console.WriteLine("_______________________");        
            //MostarSimpaticos();
        Console.WriteLine("FINAL");        
    }
    public static void MostraNum() {
        FileStream fs = new FileStream(NOMBRE_FICH_ENTRA, FileMode.Open);
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
    public static int SumarNum() {
        FileStream fs = new FileStream(NOMBRE_FICH_ENTRA, FileMode.Open);
        StreamReader sr = new StreamReader(fs);

        int acuNum = 0;
        //int num; 
        string? Linea;

        Linea = sr.ReadLine();
        while(Linea!=null){             
            try{
                // num = Convert.ToInt32(Linea);
                // acuNum += num;
                acuNum += Convert.ToInt32(Linea);
                
            } catch(FormatException){}
            Linea = sr.ReadLine();
        }       
        sr.Close(); 
        return acuNum;
    }
    public static int SumarNum2() {
        int acuNum = 0;
        FileStream fs,fs2;
        StreamReader? sr=null;
        StreamWriter? sw=null;
        int num; 
        int nLinea;
        string? Linea;
        try{
            fs = new FileStream(NOMBRE_FICH_ENTRA, FileMode.Open);
            sr = new StreamReader(fs);
            fs2 = new FileStream(NOMBRE_FICH_SALE, FileMode.Create);
            sw = new StreamWriter(fs2);
            //sr = File.OpenText(NOMBRE_FICH_ENTRA);
            //sw = File.CreateText(NOMBRE_FICH_SALE);
            nLinea = 0;
            while((Linea = sr.ReadLine())!=null){ 
                try{
                    nLinea++;
                    num = Convert.ToInt32(Linea);
                    acuNum += num;
                    
                } catch(FormatException){
                    sw.WriteLine($"{nLinea}: \"{Linea}\"");
                }
                // if(nLinea==7)
                //     //break;
                //     //throw new Exception();
                //     return -1;
            }    
        } catch(System.IO.FileNotFoundException e){
            Console.WriteLine("\n\n---> "+e.Message);
        } catch(Exception e){
            Console.WriteLine("\n\n---> "+e.Message);
        } finally {
            if(sr!=null)
                sr.Close(); 
            if(sw!=null)
                sw.Close();
        }
        return acuNum;
    }
    public static int SumarNum3() {
        int acuNum = 0;
        FileStream fs,fs2;
        StreamReader? sr=null;
        StreamWriter? sw=null;
        int num; 
        int nLinea;
        string? Linea;
        try {
            using(fs = new FileStream(NOMBRE_FICH_ENTRA, FileMode.Open))
            using(sr = new StreamReader(fs))
            using(fs2 = new FileStream(NOMBRE_FICH_SALE, FileMode.Create))
            using(sw = new StreamWriter(fs2))
            {
                //sr = File.OpenText(NOMBRE_FICH_ENTRA);
                //sw = File.CreateText(NOMBRE_FICH_SALE);

                nLinea = 0;
                while((Linea = sr.ReadLine())!=null){             
                    try{
                        nLinea++;
                        num = Convert.ToInt32(Linea);
                        acuNum += num;
                        
                    } catch(FormatException){
                        sw.WriteLine($"{nLinea}: \"{Linea}\"");
                    }
                    if(nLinea==7)
                        // break;
                        // throw new Exception();
                        return -1; 
                }    
            } 
        } catch(System.IO.FileNotFoundException e){
            Console.WriteLine("\n\n---> "+e.Message);
        } catch(Exception e){
            Console.WriteLine("\n\n---> "+e.Message);
        }             
        return acuNum;
    }
    
    public static void MostarSimpaticos() {
        FileStream fs = new FileStream(NOMBRE_FICH_ENTRA, FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        int num;
        NumeroSimpatico ns; 
        string? linea;

        
        while((linea = sr.ReadLine())!=null){             
            try{
                num = Convert.ToInt32(linea);
                ns = new NumeroSimpatico();
                //TODO
                linea = linea.Trim();
                foreach (char dig in linea) {
                    ns.addDigito(dig-'0');
                }
                if(ns.isValido()){
                    Console.WriteLine(num);
                }
            } catch(FormatException){}
        }       
        sr.Close(); 
    }
}