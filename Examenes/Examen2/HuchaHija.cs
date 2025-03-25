public class HuchaHija : Hucha
{
    public HuchaHija() : base(0) { }
    public static Hucha Sorteo(Hucha[] huchas)
    {
        List<Hucha> HuchasNoVacias = new List<Hucha>();
        int indiceAleatorio;
        foreach (Hucha hucha in huchas)
            if (hucha.Saldo() != 0)
                HuchasNoVacias.Add(hucha);
        if (HuchasNoVacias.Count == 0)
            throw new Exception("No hay huchas con saldo");
        Random r = new Random();
        indiceAleatorio = r.Next(HuchasNoVacias.Count);
        return HuchasNoVacias[indiceAleatorio];
    }

}