public class ProgramaPruebaHucha {
    public static void Main(string[] args) {

        Console.WriteLine("Alumno Eduardo Armas Dorta");

        Console.Write("\n*************************************  ");
        Console.WriteLine("Creando una hucha con 50 euros...");
        Hucha miHucha = new Hucha(50);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Añadiendo 20 euros...");
        miHucha.Añadir(20);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Intentando añadir una cantidad inválida (-10 euros)...");
        miHucha.Añadir(-10);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Sacando 30 euros...");
        miHucha.Sacar(30);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Intentando sacar más dinero del que hay en la hucha (100 euros)...");
        miHucha.Sacar(100);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Vaciando la hucha...");
        miHucha.Vaciar();
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Intentando sacar dinero de una hucha vacía (10 euros)...");
        miHucha.Sacar(10);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Terminamos metiendo dinero (2130 euros)...");
        miHucha.Añadir(2130);
        Console.WriteLine(miHucha);

        Console.Write("\n***************************************************************************************************************\n\n\n  ");

        Hucha hucha1 = new Hucha(0);
        Hucha hucha2 = new Hucha(0);
        Hucha hucha3 = new Hucha(0);
        Hucha hucha4 = new Hucha(0);
        Hucha hucha5 = new Hucha(0);
        Hucha hucha6 = new Hucha(13423);
        Hucha hucha7 = new Hucha(0);
        Hucha hucha8 = new Hucha();
        Hucha hucha9 = new Hucha(0);
        Hucha hucha10 = new Hucha(0);

        Hucha[] huchasSorteo = {hucha1,hucha2,hucha3,hucha4,hucha5,hucha6,hucha7,hucha8,hucha9,hucha10};
        
        Hucha resultado = HuchaHija.Sorteo(huchasSorteo);

        Console.WriteLine($"El ganador del sorteo es: {resultado.GetHashCode()} con saldo {resultado.Saldo()}");


        Console.Write("\n\n\n***************************************************************************************************************\n\n\n  ");












    }
}