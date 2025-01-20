namespace AMIGOINVISIBLE;
class Program
{
    static void Main(string[] args)
    {
        string[] nombres = new string[] {"Juan", "Ernesto","Sofía","Mario","Alberto"};
        int[] asignaciones = Funciones.GeneraAsignaciones(nombres.Length);
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine(nombres[i]+ " le regala a: " + nombres[asignaciones[i]]);
        }
    }
}