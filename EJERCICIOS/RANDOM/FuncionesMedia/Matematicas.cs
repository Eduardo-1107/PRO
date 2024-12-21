
namespace FuncionesMedia;
public class Matematicas {
    public static double Media(double[] datos) {
        double media = 0, suma = 0;
        int i;
        for (i = 0; i < datos.Length; i++)
            suma += datos[i];
        media = suma / i;
        return media;
    }
    public static void Media(double[] datos, out double media) {
        double suma = 0;
        int i;
        for (i = 0; i < datos.Length; i++)
            suma += datos[i];
        media = suma / i;
    }
}
