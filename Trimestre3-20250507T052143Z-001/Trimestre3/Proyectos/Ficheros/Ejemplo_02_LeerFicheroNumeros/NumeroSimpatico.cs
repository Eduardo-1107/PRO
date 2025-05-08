public class NumeroSimpatico{
    private int estado;
    private bool bloqueado;
    private bool alMenosUnDigito;

    public void addDigito(int dig){
        if(dig<0 | dig >9)
            throw new Exception();
        alMenosUnDigito=true;
        if(!bloqueado)

            switch (estado) {
                case 0:
                    if(dig ==2 | dig ==3 | dig ==9)
                        estado=1;
                    else if(dig ==6 | dig ==7 | dig ==8)
                        estado = 2;
                    break;
                case 1:
                    if(dig%2!=0)
                        estado=0;
                    break;
                default:   // case 2:
                    if(dig<5)
                        estado=0;
                    else if(dig>5)
                        estado=1;
                break;
            }
    }
    public bool isValido(){
        bloqueado=true;
        return alMenosUnDigito && estado==0;
    }

}