/*  
    Implementa las funciones disparar y extraerCoordenada para modularizar nuestro programa de “hundir la flota”.
*/
namespace FUNCIONES06;
class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Funciones
{
        public static int disparar(char[,] tablero, string coordDisparo) {
            int CodSolucion;
            int f,c;
            const char AGUA = '·';
            const char DISPARADO = '*';
            const int COD_AGUA = 1;
            const int COD_TOCADO = 2;
            const int COD_REPETIDO = 3;
            extraerCoordenada(coordDisparo, out f, out c);
            if (tablero[f,c] == AGUA) {
                tablero[f,c] = DISPARADO;
                CodSolucion = COD_AGUA;
            } 
            else if (tablero[f,c] == DISPARADO)
                    CodSolucion = COD_REPETIDO;
            else {
                CodSolucion = COD_TOCADO;
                tablero[f,c] = DISPARADO; 
            }
            return CodSolucion;
    }

    static void extraerCoordenada(string coordenada, out int fila, out int col)
    {
        char fCh;
        string cStr; 

        fCh = Char.ToUpper(coordenada[0]);
        fila = fCh - 'A'; 
        cStr = coordenada.Substring(1);
        col = Convert.ToInt32(cStr) - 1;
    }
}
