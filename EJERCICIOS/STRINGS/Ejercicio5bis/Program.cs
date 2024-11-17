
namespace STRING05BIS;
class Programa {
    public static int BLineal(string s, char ch) {
        int pos=0;
        if(s!=null) {
        while(pos<s.Length && s[pos] != ch)
            pos++;
        if (pos == s.Length)
            pos = -1;
        }
        return pos;

    }
    public static void Main(string[] args) {

        string cadena, encontradas = "";
        const string VOCALES = "aeiouAEIOU";

        Console.Write("Introduce una cadena: ");
        cadena = Console.ReadLine();
        for (int i = 0; i < cadena.Length; i++)        
            if (BLineal(VOCALES, cadena[i] ) != -1 && BLineal(encontradas,cadena[i]) == -1)
                    encontradas += cadena[i];
        Console.WriteLine("Vocales encontradas: " + encontradas); 
    }
}
    
