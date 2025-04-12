// Ejemplo_08_02a.cs
// Lectura de un fichero de texto
// Introducción a C#, por Nacho Cabanes
using System;
using System.IO; // Para StreamReader
public class Ejemplo_08_02a
{
    public static void Main()
    {
        string linea;

        StreamReader sr = new StreamReader(new FileStream("prueba.txt"), FileMode.Create);
        linea = sr.ReadLine();
        Console.WriteLine(linea);
        Console.WriteLine(sr.ReadLine());
        sr.Close();
    }
}
