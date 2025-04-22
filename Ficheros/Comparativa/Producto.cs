using System;

namespace Comparativa;

public class Producto : IComparable<Producto>
{
    private string _codigo {get;}
    private string _nombre {get;}
    private decimal _precio {get;}

    public Producto(string codigo, string nombre, decimal precio) {
        _codigo = codigo;
        _nombre = nombre;
        _precio = precio;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        return false;
        Producto otro = (Producto)obj;
        return _codigo == otro._codigo;
    }
    public override int GetHashCode() {
        return _codigo.GetHashCode();
    }
    public int CompareTo(Producto? otro)  {
        if (otro == null)
            return 1;
        return _nombre.CompareTo(otro._nombre);
    }
    public string GetCodigo() {
        return _codigo;
    }
    public string GetNombre() {
        return _nombre;
    }
    public override string ToString()
    {
        return $"Código = {_codigo}, Nombre = {_nombre}, Precio Base = {_precio}";
    }

}
