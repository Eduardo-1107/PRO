namespace Examen3;
//EDUARDO ARMAS DORTA
public class Program
{
    static void Main(string[] args)
    {
        string? linea;
        string lineaActualizada;
        double acumulacion = 0;
        double dato = 0;
        
        List<string> lista = new List<string>();
        try
        {
            using (FileStream fs = new FileStream("op.num",FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                while ((linea = sr.ReadLine()) != null)
                {
                    if (linea.Contains("acumula") || linea.Contains("ACUMULA")) {
                        lineaActualizada = linea.Substring(7).Trim();
                        try
                        {
                            dato = Convert.ToDouble(lineaActualizada);
                            lista.Add($"Acumula: {acumulacion} + {dato}");
                            acumulacion += dato;
                            lista.Add($"Resultado Parcial: {acumulacion}");
                        }
                        catch (FormatException)
                        {}
                    }
                    if (linea.Contains("divide") || linea.Contains("DIVIDE")) {
                        lineaActualizada = linea.Substring(6).Trim();
                        try
                        {
                            dato = Convert.ToDouble(lineaActualizada);
                            lista.Add($"Divide: {acumulacion} / {dato}");
                            acumulacion /= dato;
                            lista.Add($"Resultado Parcial: {acumulacion}");
                        }
                        catch (FormatException)
                        {}
                    }
                }
            }

            Console.WriteLine($"Conteo FINAL: {acumulacion:0.00}");
            foreach (string registro in lista)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(registro);
                Console.WriteLine("------------------");
            }
        }
        catch (Exception e)
        {
           Console.WriteLine("\n\t\t ----> ERROR: {0}\n", e.Message);
        }
    }
}