
public class Hucha
{
    private decimal saldo;
    private List<Movimiento> movimientos = new List<Movimiento>();

    public Hucha()
    {
        saldo = 10;
    }
    public Hucha(decimal cantidadInicial)
    {
        if (cantidadInicial < 0)
        {
            throw new Exception("No se puede inicializar la hucha con cantidades negativas.");
        }
        saldo = cantidadInicial;
    }
    public void Añadir(decimal cantidad)
    {
        if (cantidad >= 0)
            saldo += cantidad;
        RegistrarMovimiento("Añadido", cantidad, saldo);
    }
    public void Sacar(decimal cantidad)
    {
        if (saldo >= cantidad && cantidad >= 0)
            saldo -= cantidad;
        RegistrarMovimiento("Sacado", cantidad, saldo);
    }
    public void Vaciar()
    {
        RegistrarMovimiento("Vaciado", saldo, saldo);
        saldo = 0;
    }
    public decimal Saldo()
    {
        return saldo;
    }
    private void RegistrarMovimiento(string tipo, decimal cantidad, decimal saldoResultante)
    {
        if (cantidad < 0)
            tipo = "Operación anulada por valor negativo";
        if (saldo < cantidad)
            tipo = "Operación anulada por saldo insuficiente";
        cantidad = Math.Abs(cantidad);
        Movimiento movimiento = new Movimiento(tipo, cantidad, saldoResultante);
        movimientos.Add(movimiento);

    }
    public override string ToString()
    {
        foreach (Movimiento movimiento in movimientos)
            Console.WriteLine(movimiento.ToString());
        return $"---> [Ahorrado: {saldo}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Hucha otraHucha = (Hucha)obj;
        return this.saldo.Equals(otraHucha.saldo);
    }
    public override int GetHashCode()
    {
        return saldo.GetHashCode();
    }


}