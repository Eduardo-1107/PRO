/* Crear un string con 100 letras entre la A y la Z de forma aleatoria. A continuación, 
***calcular cuántas veces aparece cada letra en dicho string, 
***y mostrar este resultado por pantalla, indicando la letra, y el número de veces que aparece. */
namespace VECTOR07;
class Program {
    static void Main(string[] args) {
        char[] letras = new char[100], ABECEDARIO = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        Random letraAleatoria = new Random();
        string conjuntoLetras;
        int cont=0;
        for (int i = 0; i < letras.Length; i++) 
            letras[i] = (char)letraAleatoria.Next('A','Z' + 1);
        conjuntoLetras = string.Concat(letras);
        Console.WriteLine(conjuntoLetras);
        for (int i = 0; i < ABECEDARIO.Length;i++) {
            for (int j = 0; j < letras.Length; j++)
                if (ABECEDARIO[i] == letras[j]) 
                    cont++;
            Console.WriteLine($"La letra {ABECEDARIO[i]} se repite {cont} veces.");
            cont = 0;
        }
    }
}
