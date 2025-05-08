using System;
using System.IO;
// Para StreamReader 
public class Ejemplo_03_EscribirFichero {
    public static void Main() {
        //EscribirTextoEnFichero("texto.txt");
        EscribirBinarioEnFichero("texto.bin");
        LeerBinarioEnFichero("texto.bin");
        Console.WriteLine("*****   FIN   *******");
    }





    private static void EscribirTextoEnFichero(string nf){
        FileStream fs;
        StreamWriter sw;
        int codChar;
        try {
            using(fs = new FileStream(nf, FileMode.Create))
            using(sw = new StreamWriter(fs)) {                
                Console.Write("Texto: ");
                while((codChar=Console.Read())!='.' && codChar!=-1)
                    sw.Write(char.ToUpper((char)codChar));
            }
        }catch(Exception e){
            Console.WriteLine("PROBLEMAS: "+e.Message);
        }
    }
    private static void EscribirBinarioEnFichero(string nf){
        FileStream fs;
        BinaryWriter bw;
        int num;
        try {
            using(fs = new FileStream(nf, FileMode.Create))
            using(bw = new BinaryWriter(fs)) {
                // Console.Write("Número: ");
                // while((num=Convert.ToInt32(Console.ReadLine()))!=-1)
                //     bw.Write(num);
                bw.Write(4);
                bw.Write((4.2+.2)/3);
            }
        }catch(Exception e){
            Console.WriteLine("PROBLEMAS: "+e.Message);
        }
    }
    private static void LeerBinarioEnFichero(string nf){
        FileStream fs;
        BinaryReader br;
        int num = 0;
        double num2;
        try {
            using(fs = new FileStream(nf, FileMode.Open))
            using(br = new BinaryReader(fs)) {
                // Console.Write("Número: ");
                // while((num=Convert.ToInt32(Console.ReadLine()))!=-1)
                //     bw.Write(num);
                fs.Seek(4,SeekOrigin.Begin);
                num2 = br.ReadDouble();
                Console.Write($"Número entero: {num} \n");
                Console.Write($"Número double: {num2}\n");
            }
        }catch(Exception e){
            Console.WriteLine("PROBLEMAS Leyendo: "+e.Message);
        }
    }
}