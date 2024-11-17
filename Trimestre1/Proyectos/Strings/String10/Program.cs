internal class Programa {
    public static void Main(string[] args) {
        string frase;
        string palabra;
        int contador = 0;
        string nuevafrase = "";
        int i, j;


        Console.WriteLine("Escriba la frase");
        frase = Console.ReadLine();
        Console.WriteLine("Escriba la palabra");
        palabra = Console.ReadLine();

        bool encontrada = false;
        for (i = 0; i <= frase.Length-palabra.Length; i++) {

            j=0;
            while(j<palabra.Length-1 && i+j < frase.Length-1 &&  palabra[j]==frase[i+j])
                j++;
            if (palabra[j]==frase[i+j] && j==palabra.Length-1)
            {
                contador++;
                i += palabra.Length - 1;
            }
            else
            {
                nuevafrase += frase[i];
            }
        }
        for (j=0 ;j<palabra.Length-1 ; j++,i++) 
                nuevafrase += frase[i];


        Console.WriteLine("la nueva frase es:" + nuevafrase);
        Console.WriteLine($"Se ha elimidado: {contador} veces");
    }
}