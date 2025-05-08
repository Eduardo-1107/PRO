using facilitado;
using herencia;

class Program
{
    static void Main(string[] args)
    {
        AsistenteDeCabina a1 = new AsistenteDeCabina("Eduardo","Armas",20,1000);
        AsistenteDeCabina a2 = new AsistenteDeCabina("Javier","Maroto",18,500);
        AsistenteDeCabina a3 = new AsistenteDeCabina("Isabel","Dorta",20,2000);

        List<AsistenteDeCabina> lista = new List<AsistenteDeCabina>();

        lista.Add(a1);
        lista.Add(a2);
        lista.Add(a3);
        lista.Sort();

        foreach (AsistenteDeCabina asistenteDeCabina in lista)
        {
            Console.WriteLine(asistenteDeCabina.ToString());
        }
    }
}