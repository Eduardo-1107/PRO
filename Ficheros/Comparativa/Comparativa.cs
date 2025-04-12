
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Comparativa;

public class Comparativa
{
    private List<Articulo> _articulos {get; set;}

    public Comparativa(string rutaCSV)
    {
        _articulos = new List<Articulo>();
        FileStream fs;
        StreamReader sr;
        string linea; 
        string[] datos;
        try
        {
            using (fs = new FileStream(rutaCSV, FileMode.Open))
            using (sr = new StreamReader(fs))
            {
                while ((linea = sr.ReadLine()) != null)
                {
                    datos = linea.Split(';');

                    if (datos.Length == 4) {
                        AñadirArticulo(datos[0],datos[1],datos[2],Convert.ToDecimal(datos[3]));

                    } else {
                        Console.WriteLine("Formato de linea incorrecto." + datos.Length);
                    }
                }
            }
    
        }
        catch (Exception e)
        {
            Console.WriteLine("Problemas: " + e.Message);  
        }
    }

    public void GuardarCSV(string nuevaRuta)
    {
        FileStream fs;
        StreamWriter sw;
        using (fs = new FileStream(nuevaRuta,FileMode.Create))
        using(sw = new StreamWriter(fs))
        {
            foreach (Articulo articulo in _articulos)
            {
                sw.WriteLine(articulo.ToString());
            }
        }
    }

    public void AñadirArticulo(string vendedor, string codigo, string nombre, decimal precio)
    {
        Producto producto = new Producto(codigo,nombre,precio);
        Articulo articulo = new Articulo(vendedor,producto,precio);
        _articulos.Add(articulo);
    }
    public void ModificarPrecio(string codigo, string vendedor, decimal nuevoPrecio)
    {
        bool encontrado = false;
        int i = 0;
        while (!encontrado) {
            if ((codigo == _articulos[i].GetCodProducto()) && (vendedor == _articulos[i].GetVendedor()))
            {
                _articulos[i].SetPrecio(nuevoPrecio);
                encontrado = true;
            }
            i++;
        }
    }
    public override string ToString()
    {
        StringWriter sw = new StringWriter();
        foreach (Articulo articulo in _articulos)
        {
            Console.WriteLine("Hola");
            sw.WriteLine($"{articulo.GetProducto().ToString()}, Vendedor: {articulo.GetVendedor()}, Precio: {articulo.GetPrecio()}");
        }
        return sw.ToString();
    }
    public string ListarPreciosDeProducto(string codigo)
    {
        StringWriter sw = new StringWriter();
        
        sw.WriteLine($"=== Precios del producto {codigo} ===");
        foreach (Articulo articulo in _articulos)
        {
            if (articulo.GetCodProducto() == codigo)
                sw.WriteLine($"{articulo.GetVendedor()}:    {articulo.GetPrecio()}");   
        }


        return sw.ToString();
    }


}
