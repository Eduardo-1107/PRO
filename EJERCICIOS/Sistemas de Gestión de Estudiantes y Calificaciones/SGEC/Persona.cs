namespace SISTEMA_GESTION_ESTUDIANTES_CALIFICACIONES;
public class Persona
{
    public string Nombre { get; }
    public int Edad { get; }
    private DNI _dni;
    public string Dni
    {
        get
        {
            return _dni.ToString();
        }
    }
    public Persona(int edad, int numeroDni, char letraDni)
        : this("Desconocido", ValidarEdad(edad), numeroDni, letraDni)
    {
    }
    public Persona(string nombre, int edad, int numeroDni, char letraDni)
    {
        Nombre = nombre;
        Edad = ValidarEdad(edad);
        _dni = new DNI(numeroDni, letraDni);
    }
    private static int ValidarEdad(int edad)
    {
        if (edad <= 0)
            throw new ArgumentOutOfRangeException("La edad debe ser mayor que 0");
        return edad;
    }
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}, {Dni}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;
        Persona persona = (Persona)obj;
        return Nombre == persona.Nombre && Edad == persona.Edad && _dni == persona._dni;
    }
    public override int GetHashCode()
    {
        return (Nombre, Edad, _dni).GetHashCode();
    }

}