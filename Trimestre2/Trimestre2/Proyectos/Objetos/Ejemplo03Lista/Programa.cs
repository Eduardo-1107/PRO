public class Programa {
  public static void Main(String[] arg) {
    ListaDeEnteros l = AmigoInv.generaAsignaciones(5);
    System.Console.WriteLine(l);
    /*
    ListaDeEnteros l = new ListaDeEnteros();
    l.Add(5);
    l.Add(-30);
    l.Add(51);
    l.Add(-3);
    l.Add(15);
    l.Add(23);
    l.Add(99);
    l.Add(0);
    l.Add(0);
    l.Add(-9);
    l.Add(1);
    l.Add(31);
    for (int i = 0; i < l.Length(); i++)
    {
        System.Console.WriteLine($"datos[{i}]={l.Get(i)}");
    }
    */
  }
}