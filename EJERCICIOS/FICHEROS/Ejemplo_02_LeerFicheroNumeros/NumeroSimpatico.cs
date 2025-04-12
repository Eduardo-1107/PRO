public class NumeroSimpatico
{
    private static int _estado = 0;

    public void AddDigito(int dig) {
        switch (_estado)
        {
            case 0:
                if (dig == 0 || dig == 1 || dig == 5 || dig == 4)
                    _estado = 0; 
                else if (dig == 2 || dig == 3 || dig == 9)
                    _estado = 1; 
                else if (dig > 5) 
                    _estado = 2; 
                break;

            case 1:
                if (dig % 2 == 0)
                    _estado = 1; 
                else
                    _estado = 0; 
                break;

            case 2:
                if (dig == 5)
                    _estado = 2;
                else if (dig > 5)
                    _estado = 2; 
                else
                    _estado = 0; 
                break;
        }
        
    }
    public bool IsValido() {
        if (_estado == 0)
            return true;
        else
            return false; 
    }
}