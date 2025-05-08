namespace Negocio;

public class Producto : IComparable<Producto> {
    private static List<Producto> existentes = new();
    public string Codigo {get; private set;}
    public string Nombre {get; private set;}
    

    public Producto(string Codigo, string Nombre) {
        this.Codigo = Codigo;
        this.Nombre = Nombre;
        if(existentes.Contains(this))
            throw new Exception();
        existentes.Add(this);
    }


    public int CompareTo(Producto? otro) {
        if (otro == null)
            return 1;
        return Nombre.CompareTo(otro.Nombre);
    }

    public override bool Equals(object? obj) {
        if (obj == null || GetType() != obj.GetType()) 
            return false;
        Producto otro = (Producto)obj;
        return Codigo == otro.Codigo;
    }

    public override int GetHashCode() {
        return Codigo.GetHashCode();
    }

    public override string ToString() {
        return $"{Nombre} ({Codigo})";
    }
}