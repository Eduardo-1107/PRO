namespace AHORCADO;
public class Program
{
    static void Main(string[] args)
    {
        //Variables 
        int opcionPrincipal, opcionSubmenu, numFallos;
        char[] cadenaAciertos, letrasUtilizadas;
        string cadenaSecreta;
        bool flag = true;


        // Programa
        while (flag)
        {
            flag = false;
            try
            {
                do
                {
                    Menu.VerMenu(0);
                    opcionPrincipal = Menu.LeerOpcion("Seleccione una opción: ");
                    switch (opcionPrincipal)
                    {
                        case '0':
                            Console.Clear();
                            break;
                        case '1':
                            do
                            {
                                Menu.VerMenu(1);
                                opcionSubmenu = Menu.LeerOpcion("Seleccione una opción: ");
                                switch (opcionSubmenu)
                                {
                                    case '1': // Crea tú tu propia palabra
                                        Menu.VerMenu(2);
                                        Console.Write("Escribe la palabra secreta: ");
                                        Game.LeerSecreto(out cadenaAciertos, out cadenaSecreta);
                                        letrasUtilizadas = new char[cadenaAciertos.Length];
                                        Console.Clear();
                                        Game.MostrarAhorcado(0);
                                        
                                        Console.WriteLine("\n" + Game.EscribirSecreto(ref cadenaAciertos, letrasUtilizadas));
                                        Console.ReadKey();
                                        opcionSubmenu = '0';
                                        opcionPrincipal = '0';
                                        break;
                                    case '2':
                                        break;
                                }
                            } while (opcionSubmenu != '0');
                            break;
                    }
                } while (opcionPrincipal != '0');
            }
            catch (FormatException e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
                Console.WriteLine($"Lugar del error: {e.StackTrace}");
                Funcion.BorrarPantalla();
                flag = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
                Console.WriteLine($"Lugar del error: {e.StackTrace}");
                Funcion.BorrarPantalla();
                flag = true;
            }
            finally 
            {
                Console.WriteLine("Gracias por jugar al juego.");
            }
        }
    }
}