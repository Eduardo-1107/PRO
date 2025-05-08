using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Transactions;
using facilitado;
namespace herencia;

public class AsistenteDeCabina : Persona, IComparable<AsistenteDeCabina>, Disponible
{
    private int horasVuelos;
    public string _nombre {get {return base.getNombre();}}
    public int _edad {get {return base.getEdad();}}

    public AsistenteDeCabina(string nombre, string apellidos, int edad, int horasVuelos):base(nombre,apellidos,edad) {
        this.horasVuelos = horasVuelos;
    }

    public bool haceVuelosTransatlanticos() {
        bool haceVuelosTransatlanticos;
        if (_edad <= 50 && _edad >= 25 && horasVuelos > 1000)
            haceVuelosTransatlanticos = true;
        else
         haceVuelosTransatlanticos = false;
        return haceVuelosTransatlanticos;
    }
    public int CompareTo(AsistenteDeCabina? otroA)
    {
        if (otroA == null)
            return 1;
        return horasVuelos.CompareTo(otroA.horasVuelos);
    }
    public override string ToString() {
        return $"{_nombre},{_edad},{horasVuelos}";
    }
    // public static int HorasVuelosTotales() {
        
    // }
    
}