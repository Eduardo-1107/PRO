namespace AMIGOINVISIBLE;
class Funciones
{
    public static int[] GeneraAsignaciones (int part) {
        Random r = new Random();
        int[]nombresAsignados =  new int[part];
        int pos, aux, i;

        for (i = 0; i < nombresAsignados.Length; i++) {
            nombresAsignados[i] = i;   
        }
        for (i = 0; i < part -1 ; i++) {
            pos = r.Next(i+1,part);
            aux = nombresAsignados[i];
            nombresAsignados[i] = nombresAsignados[pos]; 
            nombresAsignados[pos] = aux; 
        } 
        return nombresAsignados;
    }
}