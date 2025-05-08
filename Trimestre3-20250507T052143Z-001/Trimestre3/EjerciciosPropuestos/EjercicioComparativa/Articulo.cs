namespace Negocio;

public class Articulo {
    public string Vendedor {get; private set;}
    public Producto Producto {get; private set;}
    private decimal _Precio;
    public decimal Precio {
        get {return _Precio;}
        set{
            if(value<0)
                throw new ArgumentOutOfRangeException("No se admiten precios negativos.");
            _Precio = value;
        }
    }

    public Articulo(string vendedor, Producto producto, decimal precio) {  
        Vendedor = vendedor;
        Producto = producto;
        Precio = precio;
    }
    public Articulo(string vendedor,  string codigo, string nombre, decimal precio) {  
        Vendedor = vendedor;
        Producto = new Producto(codigo,nombre);
        Precio = precio;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Articulo otro = (Articulo)obj;
        return Vendedor.ToLower() == otro.Vendedor.ToLower() && Producto.Codigo == otro.Producto.Codigo;
    }

    public override int GetHashCode()
    {
        return (Vendedor.ToLower(), Producto.Codigo).GetHashCode();
    }

    public override string ToString(){
//        return $"{Vendedor}  - {Producto}:   {Precio}€"
        return $"  {Vendedor,-20}|{Producto+": ",30}{Precio,7:.00} €";
    }
    
}