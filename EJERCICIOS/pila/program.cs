using System;

class PilaArray
{
    private int[] elementos;
    private int tope; // Índice del último elemento
    private int capacidad; // Tamaño máximo de la pila

    // Constructor
    public PilaArray(int tamaño)
    {
        capacidad = tamaño;
        elementos = new int[capacidad];
        tope = -1; // Indica que la pila está vacía
    }

    // Método para agregar un elemento (Push)
    public void Push(int elemento)
    {
        if (tope == capacidad - 1)
        {
            Console.WriteLine("Error: La pila está llena.");
            return;
        }
        elementos[++tope] = elemento;
    }

    // Método para eliminar y devolver el elemento superior (Pop)
    public int Pop()
    {
        if (tope == -1)
        {
            Console.WriteLine("Error: La pila está vacía.");
            return -1; // Valor de error
        }
        return elementos[tope--];
    }

    // Método para ver el elemento superior sin eliminarlo (Peek)
    public int Peek()
    {
        if (tope == -1)
        {
            Console.WriteLine("Error: La pila está vacía.");
            return -1;
        }
        return elementos[tope];
    }

    // Método para verificar si la pila está vacía
    public bool EstaVacia()
    {
        return tope == -1;
    }

    // Método para mostrar la pila
    public void MostrarPila()
    {
        if (tope == -1)
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Elementos en la pila:");
        for (int i = tope; i >= 0; i--)
        {
            Console.WriteLine(elementos[i]);
        }
    }
}

// **Ejemplo de uso**
class Program
{
    static void Main()
    {
        PilaArray pila = new PilaArray(5);

        pila.Push(10);
        pila.Push(20);
        pila.Push(30);
        
        pila.MostrarPila();

        Console.WriteLine($"Elemento en la cima: {pila.Peek()}");
        Console.WriteLine($"Elemento eliminado: {pila.Pop()}");

        pila.MostrarPila();
    }
}
