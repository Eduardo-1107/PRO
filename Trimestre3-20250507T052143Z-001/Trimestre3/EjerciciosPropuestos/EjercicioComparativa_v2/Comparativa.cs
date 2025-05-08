namespace Negocio;

public class Comparativa
{
    private List<Articulo> Articulos = new List<Articulo>();


    public Comparativa(string fichero) {
        string? linea;
        string[] separado;

        // if (!File.Exists(fichero))
        //     throw new ArgumentException($"El fichero \"{fichero}\" no se ha encontrado.");

        try {
            using (StreamReader sr = File.OpenText(fichero)) {
                while ((linea = sr.ReadLine()) != null){
                    try {
                        separado = linea.Split(";");
                        AñadirArticulo(separado[0], separado[1], separado[2], Convert.ToDecimal(separado[3]));
                    } catch (IndexOutOfRangeException) {
                    } catch (FormatException){
                    }
                }
            }
        } catch(Exception e) {
            System.Console.WriteLine("\n\t\t ----> ERROR: {0}\n", e.Message);
        }
    }


    public void AñadirArticulo(string negocio, string codigo, string producto, decimal precio) {
        //int i = 0;
        Articulo nuevoArticulo = new Articulo(negocio, Producto.creaProducto(codigo, producto), precio);

        // while (i < Articulos.Count && !Articulos[i].Equals(nuevoArticulo))
        //     i++;
        // // Si llego al final es que no he encontrado ningún artículo como el que quiero añadir, por tanto, no se repite
        // if (i == Articulos.Count)
        //     Articulos.Add(nuevoArticulo);
        if (!Articulos.Contains(nuevoArticulo))
            Articulos.Add(nuevoArticulo);
    }

    public void ModificarPrecio(string codigo, string vendedor, decimal NuevoPrecio)
    {
        int i = 0;
        while (i < Articulos.Count && Articulos[i].Vendedor != vendedor && Articulos[i].Producto.Codigo != codigo)
            i++;
        if (i != Articulos.Count)
            Articulos[i].Precio = NuevoPrecio ;
    }


    public void GuardarCSV(string ruta) {
        using(StreamWriter sw = File.CreateText(ruta))
            foreach (Articulo art in Articulos)
                sw.WriteLine($"{art.Vendedor};{art.Producto.Codigo};{art.Producto.Nombre};{art.Precio}");
    }

    public override string ToString()
    {
        string salida = "=== Comparativa de precios ===\n";
        foreach (Articulo art in Articulos)
        {
//            salida += $"  {art.Vendedor,-20}|{art.Producto.Nombre + " (" + art.Producto.Codigo + "): ",30}{art.Precio,7:.00} €\n";
            salida += $"{art}\n";
        }
        return salida;
    }

    public string ListarPreciosDeProducto(string CodigoProducto)
    {
        string salida = $"=== Precios del producto {CodigoProducto} ===\n";
        foreach (Articulo art in Articulos)
            if (art.Producto.Codigo == CodigoProducto)
                salida += $"{art.Vendedor + ":  ",20}{art.Precio,6:.00} €\n";

        return salida;
    }
}