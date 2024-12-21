// Dada una temperatura en grados Celcius, realizar una función que convierta esa cantidad a grados Fahrenheit y otra a grados Kelvin.
namespace FUNCIONES01;
class Program {
    static void Main(string[] args)
    {
        
    }
}

class Funciones {
    public static double ConvertirFahrenheit (double celcius) {
        return 1.8*celcius+32;
    }
        public static double ConvertirKelvin (double celcius) {
        return 273.15 + celcius;
    }
}
