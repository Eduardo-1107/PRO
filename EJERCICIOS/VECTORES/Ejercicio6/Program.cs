/* Recogidos los datos del nombre de diez alumnos, 
y la nota que han obtenido en un examen, calcular la media de las notas de los diez alumnos, 
e indicar el nombre de los alumnos que tienen una nota inferior a la media. */
namespace VECTOR06;
class Program {
    static void Main(string[] args) {
       string[] alumnos = new string[10];
       double[] nota = new double[10];
       double media,suma = 0,cont = 0;

       Console.WriteLine($"Escribe el nombre y la nota de cada alumno.");
       for (int i = 0; i < alumnos.Length;i++) {
        Console.Write($"\nNombre alumno {i+1}: ");
        alumnos[i] = Console.ReadLine();
        Console.Write($"Nota de alumno {i+1}: ");
        nota[i] = Convert.ToDouble(Console.ReadLine());
        suma += nota[i];
        cont++;
       }
       media = suma/cont;
       Console.WriteLine($"La media es: {media:f2}\n");
       for (int i = 0; i < alumnos.Length;i++)
        Console.WriteLine($"{alumnos[i]} tiene una nota {(nota[i] < media ? "inferior" : "superior")} a la media [{nota[i]}]\n"); //No es exactamente lo que pide el ejercicio pero quería probar los operadores ternarios.
    }
}