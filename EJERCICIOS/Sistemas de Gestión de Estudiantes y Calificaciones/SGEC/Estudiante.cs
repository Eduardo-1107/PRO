namespace SISTEMA_GESTION_ESTUDIANTES_CALIFICACIONES;
using System.Linq;
class Estudiante : Persona, IComparable<Estudiante>
{
    private List<Calificacion> calificaciones;

    public Estudiante(int edad, string numeroDni, char letraDni) : base("Desconocido", edad, numeroDni, letraDni)
    {
        calificaciones = new List<Calificacion>();
    }
    public Estudiante(string nombre, int edad, string numeroDni, char letraDni) : base(nombre, edad, numeroDni, letraDni)
    {
        calificaciones = new List<Calificacion>();
    }
    public void Calificar(Calificacion calificacion)
    {
        calificaciones.Add(calificacion);
    }
    public float NotaMedia()
    {
        float notaMedia;

        if (calificaciones.Count != 0)
        {
            float suma = 0;
            for (int i = 0; i < calificaciones.Count; i++)
                suma += calificaciones[i].Nota;
            notaMedia = suma / calificaciones.Count;
        }
        else
            notaMedia = -1;
        return notaMedia;
    }
    public int CompareTo(Estudiante? otroE)
    {
        if (otroE == null)
            return 1;
        return NotaMedia().CompareTo(otroE.NotaMedia());
    }
    public override string ToString()
    {
        if (NotaMedia() == -1)
            return $"{base.ToString()} Nota Media: No se han encontrado calificaciones";
        else
        for (int i = 0; i < calificaciones.Count; i++)
            Console.WriteLine($"{base.ToString()} {calificaciones[i].Asignatura}: {calificaciones[i].Nota}"); 
        return $"{base.ToString()} Nota Media: {NotaMedia():F2}";
    }


}