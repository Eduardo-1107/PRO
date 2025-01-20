public class ListaDeEnteros
{
    private int[] datos = new int[10];
    private int nDatos;

    private void CrecerSiEsNecesario () {
        if (nDatos == datos.Length)
        {
            int[] aux;
            aux = new int[datos.Length + 10];
            for (int i = 0; i < datos.Length; i++)
                aux[i] = datos[i];
            datos = aux;
        }
    }
    public void Add(int n)
    {
        CrecerSiEsNecesario();
        datos[nDatos] = n;
        nDatos++;
    }
    public int Length()
    {
        return nDatos;
    }
    public int Get(int pos)
    {
        if (pos >= nDatos)
            throw new Exception();
        return datos[pos];
    }
    public int Delete(int pos)
    {
        int aux;
        if (pos >= nDatos)
            throw new Exception();
        aux = datos[pos];
        for (int i = pos; i < nDatos - 1; i++)
            datos[i] = datos[i + 1];
        nDatos--;
        return aux;
    }

    public int Set(int pos, int n)
    {
        int aux;
        if (pos >= nDatos)
            throw new Exception("Fuera de rango de la tabla");
        aux = datos[pos];
        datos[pos] = n;
        return aux;
    }

    public override string ToString()
    {
        string lista = "{";
        for (int i = 0; i < nDatos - 1; i++)
            lista += $"{datos[i]}, ";
        if (nDatos != 0)
            lista += datos[nDatos - 1];
        lista += "}";
        return lista;
    }
}