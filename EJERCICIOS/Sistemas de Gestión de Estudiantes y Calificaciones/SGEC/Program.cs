using System.Net;

namespace SISTEMA_GESTION_ESTUDIANTES_CALIFICACIONES;
class Program
{
    static void Main(string[] args)
    {
        //e = Estudiante, c = calificación.

        Console.Clear();


        try
        {
            Estudiante e1 = new Estudiante("Eduardo",20,43485970,'P'); 
            Estudiante e2 = new Estudiante(18,12345678,'Z');           
            Estudiante e3 = new Estudiante("Isabel",20,43839670,'Z');  
            Estudiante e4 = new Estudiante("Jose",21,87654321,'X');   
            
    
            Calificacion c1e1 = new Calificacion("Matematicas",6.4F);
            Calificacion c2e1 = new Calificacion("Lengua",4.7F);
            Calificacion c3e1 = new Calificacion("Inglés",2.1F);
            e1.Calificar(c1e1);
            e1.Calificar(c2e1);
            e1.Calificar(c3e1);
    
            Calificacion c1e3 = new Calificacion("Matematicas",8.8F);
            Calificacion c2e3 = new Calificacion("Lengua",8.4F);
            Calificacion c3e3 = new Calificacion("Inglés",9.9F);
            e3.Calificar(c1e3);
            e3.Calificar(c2e3);
            e3.Calificar(c3e3);
    
            Calificacion c1e4 = new Calificacion("Matematicas",8.1F);
            Calificacion c2e4 = new Calificacion("Lengua",6.9F);
            Calificacion c3e4 = new Calificacion("Inglés",7.4F);
            e4.Calificar(c1e4);
            e4.Calificar(c2e4);
            e4.Calificar(c3e4);
    
    
            // Console.WriteLine(e1.ToString() + "\n");
            // Console.WriteLine(e2.ToString() + "\n");
            // Console.WriteLine(e3.ToString() + "\n");
            // Console.WriteLine(e4.ToString() + "\n");
            
    
            Console.WriteLine("\n\n\nEstudiantes ordenados: \n");
            List<Estudiante> estudiantes = [e1,e2,e3,e4];  
            estudiantes.Sort();
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("\n" + estudiante.ToString() + "\n\n");
            }
    
            Console.WriteLine("Persona con DNI: 1000001S");
            DNI dniBuscado = new DNI(10000001,'S');
            bool Encontrado = false;
            foreach (Estudiante estudiante in estudiantes)
            {
                if (estudiante.Dni.Equals(dniBuscado.ToString()))
                {
                    Console.WriteLine($"El estudiante con {dniBuscado} se llama {estudiante.Nombre}" );
                    Encontrado = true;
                }
            }
            if (!Encontrado)
            {
                Console.WriteLine("El alumno no ha sido encontrado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Inesperado: {ex}");
        }

    }
}