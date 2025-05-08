namespace Negocio;

public class Producto : IComparable<Producto> {
    private static List<Producto> existentes = new();
    public string Codigo {get; private set;}
    public string Nombre {get; private set;}
    
    public static Producto creaProducto(string Codigo, string Nombre) {
        Producto p = new Producto(Codigo,Nombre);
        int pos = existentes.IndexOf(p);
        if(pos==-1)
            existentes.Add(p);
        else
            p = existentes[pos];
        return p;    
    }

    private Producto(string Codigo, string Nombre) {
        this.Codigo = Codigo;
        this.Nombre = Nombre;
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
        return (Codigo).GetHashCode();
    }

    public override string ToString() {
        return $"{Nombre} ({Codigo})";
    }

}