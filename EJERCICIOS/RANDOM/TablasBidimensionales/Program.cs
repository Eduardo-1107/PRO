namespace TablasBidimensionales;

/*
    double[] Totales (double[,] ingresos)
    void Mostrar (double[,])

    Devuelve tabla de double[] que sume todos las columnas

*/

class Program {
    static void Main(string[] args) {
        double[,] dDatos = {
            { 1.2, 2.3, 3.4 },
            { 4.5, 5.6, 6.7 },
            { 7.8, 8.9, 9.1 }
        };
        try
        {
            double[] dSumasTotales = Funciones.Totales(dDatos);
            Funciones.Mostrar(dDatos);
            Console.WriteLine();
            Console.WriteLine("Totales: ");
            foreach (double dSuma in dSumasTotales)
                Console.WriteLine($"{dSuma,4:0.00}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}

class Funciones {
    public static double[] Totales (double[,] dTabla) {
        double[] dTablaTotal = new double[dTabla.GetLength(0)];
        for (int i = 0; i < dTabla.GetLength(1); i++)
            for (int j = 0; j < dTabla.GetLength(0); j++) 
                dTablaTotal[i] += dTabla[j,i]; 
        return dTablaTotal;
    }
    public static void Mostrar(double[,] ingresos) {
        for (int i = 0; i < ingresos.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < ingresos.GetLength(1); j++)
                Console.Write(ingresos[i,j] + " | ");
        }
    }

    public static double[,] CrearDatos (int fil, int col) {
        double[,] nueva = new double[fil,col];
        Random 
        for (int f = 0; f < nueva.GetLength(0); f++)
        {
            
        }
    }
}