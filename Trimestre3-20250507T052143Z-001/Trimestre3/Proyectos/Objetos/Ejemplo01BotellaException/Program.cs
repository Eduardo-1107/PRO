class PruebaBotella
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("\nCon la botella de un litro...");
            Botella a = new Botella();
            float cantidad = a.Anadir(1.5f);
            Console.WriteLine("Al añadir 1.5 sobran: " + cantidad);
            cantidad = a.Quitar(0.3f);
            Console.WriteLine("Y al después quitar 0.3 consigo sacar: " + cantidad);

            Console.WriteLine("\nCon la botella de 3.5 litros...");
            a = new Botella(-3.5f);
            cantidad = a.Anadir(1.5f);
            Console.WriteLine("Al añadir 1.5 sobran: " + cantidad);
            cantidad = a.Quitar(0.3f);
            Console.WriteLine("Y al después quitar 0.3 consigo sacar: " + cantidad);
        }
        catch (ExceptionCapacidadBotella e){
            Console.WriteLine($"Excepcion de Botella: {e.ParamName}");
        }
        catch (ArgumentException e){
            Console.WriteLine($"Excepcion: {e.ParamName}");
        }
        catch (Exception e){
            Console.WriteLine("Algo fue mal.");
            Console.WriteLine(e);
        }
        Console.WriteLine("FIN");
    }
}
