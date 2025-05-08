
public class Program
{
    public static void Main(string[] args)
    {
        try{
        Punto p = null; //new Punto(14, 11);
        Punto q = new Punto(14, 11);
        Console.WriteLine($"dist({p},{q})={p.Distancia(q):f2}");
        Console.WriteLine(p.Equals(q));
        } catch(PuntoFueraDeLimiteException p){
            Console.WriteLine($"Error: {p.ParamName}");
        } catch(Exception e){
            Console.WriteLine($"Algo ha ido mal");
            Console.WriteLine($"Error: {e.Message}");
        }
        // PuntoGordo p1 = new PuntoGordo(14, 10, 2);
        // PuntoGordo q1 = new PuntoGordo(15, 20, 1);
        // Console.WriteLine($"p1 = {p1}");
        // Console.WriteLine($"q1 = {q1}");
        // Console.WriteLine($"dist({p1},{q1})={p1.Distancia(q1):f2}");
        // Console.WriteLine(p1.Equals(q1));
    }
}

