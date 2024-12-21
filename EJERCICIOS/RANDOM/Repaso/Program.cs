
class Program
{
    static void Main(string[] args)
    {
        int dia, mes, año;
        int diaSiguiente, mesSiguiente, añoSiguiente;
        int dias = 0;
        try
        {
            Console.Write("Introduzca Día: ");
            dia = LeerDia();
            Console.Write("Introduzca Mes: ");
            mes = LeerMes();
            Console.Write("Introduzca Año: ");
            año = LeerAño();
            comprueba(dia, mes, año);
            diaSiguiente = dia + 1;
            mesSiguiente = mes;
            añoSiguiente = año;
             Console.Write("Fecha hoy: ");
            Console.Write("{0}/{1}/{2}", dia, mes, año);
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                case 2:
                    if (bisiesto(año))
                        dias = 29;
                    else
                        dias = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
            }
            if (diaSiguiente > dias)
            {
                diaSiguiente = 1;
                if (mesSiguiente == 13)
                {
                    mesSiguiente = 1;
                    añoSiguiente++;
                    if (añoSiguiente == 0)
                        añoSiguiente = 1;
                }
            }
            Console.Write("\nFecha: ");
            Console.Write("{0}/{1}/{2}", diaSiguiente, mesSiguiente, añoSiguiente);
        }
        catch (Exception ex) {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
    } 
    static bool bisiesto(int aa) => (aa % 4 == 0) && (aa % 100 != 0) || (aa % 400 == 0);
   
    static void comprueba(int dd, int mm, int aa)
    {
        int ddmax;  
            if (mm == 2)
                if (bisiesto(aa))
                    ddmax = 29;
                else
                    ddmax = 28;
            else if ((mm == 4) || (mm == 6) || (mm == 9) || (mm == 11))
                ddmax = 30;
            else
                ddmax = 31;
            if (dd < 1 || dd > ddmax)
                throw new Exception($"La fecha {dd}/{mm}/{aa} es incorrecta");
    }

    private static int LeerDia()
    {
        int d;
        d = Convert.ToInt32(Console.ReadLine());
        if (d < 1 | d > 31)
            throw new FormatException("El día tiene que ser un valor entre 1 y 31");
        return d;
    }
    private static int LeerMes()
    {
        int m;
        m = Convert.ToInt32(Console.ReadLine());
        if (m < 1 | m > 12)
            throw new FormatException("El mes tiene que ser un valor entre 1 y 12");
        return m;

    }
    private static int LeerAño()
    {
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        if (a == 0)
            throw new FormatException("El año NO puede ser 0");
        return a;
    }

    

}
