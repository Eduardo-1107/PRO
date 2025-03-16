namespace SISTEMA_GESTION_ESTUDIANTES_CALIFICACIONES;
public class Calificacion
{
    public string Asignatura { get; }
    public float Nota { get; }
    public Calificacion(string asignatura, float nota)
    {
        if (nota < 0 || nota > 10)
            throw new Exception("La nota está fuera del rango establecido.");
        Asignatura = asignatura;
        Nota = nota;
    }
    public override string ToString()
    {
        return $"{Asignatura}: {Nota:F2}";
    }
}