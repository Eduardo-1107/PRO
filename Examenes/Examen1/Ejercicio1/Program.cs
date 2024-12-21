namespace PARCIAL1;
public class Ejercicio1 {

    public static string Reproducir (char[] a, char[] b) {
        string dato = "";
        int probabilidad;
        Random probabilidadRandom = new Random();

        for (int i = 0; i < a.Length;i++) {
            probabilidad = probabilidadRandom.Next(0,2); //Si retora 0 se eligirá el array "a" y si retorna 1 se elegirá el array "b"
            if (probabilidad == 0)
                dato += a[i];
            if (probabilidad == 1)
                dato += b[i];
        }
        return dato;
    }
}

public class Ejercicio2 {
    public static string Ganador (double[] tiempos, string[] nombres, double[] penalizaciones, out double[] totales) {
        string nGanador;
        double tiempoMenor = double.MaxValue;
        int posicionGanador = 0;
        double[] tiemposTotal = new double[tiempos.Length];
        for (int i = 0; i < nombres.Length; i++) {
           tiemposTotal[i] = tiempos[i] + penalizaciones[i];
           if (tiempoMenor > tiemposTotal[i]) 
                tiempoMenor = tiemposTotal[i];
        }
        totales = tiemposTotal;
        while ((posicionGanador < nombres.Length) && (tiempoMenor != tiemposTotal[posicionGanador]))
            posicionGanador++;
        nGanador = nombres[posicionGanador];
        return nGanador;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        double[] tiempos = new double[] {1.50,1.48,2.06,1.50,1.69,2.06,1.88,1.92}; //Se puede simplificar
        double[] penalizaciones = new double[] {0.10,0.20,0.00,0.00,0.00,0.04,0.00,0.60};
        string[] nombres = new string[] {"Aitor","Felisa","Jonay","Ester","Ángela","Tomás","Óscar","Taida"};
        double[] tiemposTotales = new double[tiempos.Length];
        Console.WriteLine($"GANADOR/A: {Ejercicio2.Ganador(tiempos,nombres,penalizaciones, out tiemposTotales)}");
        Console.WriteLine("TOTALES");
        foreach (double tiempo in tiemposTotales)
            Console.WriteLine($"{tiempo:f2}"); 
    }
}
