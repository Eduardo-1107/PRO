namespace SISTEMA_GESTION_ESTUDIANTES_CALIFICACIONES;
public class DNI
{
    public  string NDni { get; }
    public char LDni { get; }
    private static readonly char[] LetrasDni = ['T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K'];

    public DNI(string numeroDni, char letraDni)
    {
        if (LetraValida(numeroDni, letraDni))
        {
            NDni = numeroDni;
            LDni = letraDni;
        }
    }
    private bool LetraValida(string numeroDni, char letraDni)
    {
        char letraEsperada;
        int resto;
        

        if (numeroDni.Length == 8) {
            resto = Convert.ToInt32(numeroDni) % 23;
            letraEsperada = LetrasDni[resto];
        }
        else
            throw new Exception($"La cantidad de dígitos es {numeroDni} y es incorrecta, deben ser 8");
        if (letraEsperada == letraDni)
            return true;
        else
            throw new Exception($"La letra {letraDni} no corresponde al número de DNI {numeroDni} o no es mayúscula");

    }
    public override string ToString()
    {
        return $"{NDni}{LDni}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;
        DNI dni = (DNI)obj;
        return NDni == dni.NDni && LDni == dni.LDni;
    }
    public override int GetHashCode()
    {
        return (NDni, LDni).GetHashCode();
    }
}