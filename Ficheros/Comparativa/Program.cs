using System.Security.Cryptography.X509Certificates;

namespace Comparativa;
class Program
{
    static void Main(string[] args)
    {
        const string NOMBRE_FICH = "HojaCalculo.csv" ;


        Comparativa comp = new Comparativa(NOMBRE_FICH);
        comp.AñadirArticulo("MediaMarkt", "P002", "Smartphone", (decimal)599.99);
        comp.AñadirArticulo("Amazon", "P002", "Smartphone", (decimal)599.99);
        comp.AñadirArticulo("Amazon", "P002", "Smartphone", (decimal)599.99);
        comp.ModificarPrecio("P001", "Amazon", (decimal)1150.00);
        Console.WriteLine(comp.ListarPreciosDeProducto("P002"));
        comp.GuardarCSV("datos_actualizados.csv");
    }
}
