namespace Comparativa;

public class Articulo
{
    private string _vendedor{get;}
    private Producto _producto;   
    private decimal _precio {get;set;}
    public Articulo(string vendedor, Producto producto, decimal precio) {
        _vendedor = vendedor;
        _producto = producto;
        _precio = precio;
    }
    public string GetVendedor() {
        return _vendedor;
    }
    public string GetCodProducto () {
        return _producto.GetCodigo();
    }
    public decimal GetPrecio () {
        return _precio;
    }
    public Producto GetProducto() {
        return _producto;
    }
    public void SetPrecio(decimal nuevoPrecio) {
        _precio = nuevoPrecio;
    }
    public override string ToString()
    {
        return $"{_vendedor};{_producto.GetCodigo()};{_producto.GetNombre()};{_precio}";
    }
}
