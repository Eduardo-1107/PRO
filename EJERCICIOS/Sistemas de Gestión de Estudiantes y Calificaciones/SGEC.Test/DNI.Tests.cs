namespace SISTEMA_GESTION_ESTUDIANTES_CALIFICACIONES;
using Xunit;
public class DNITests
{
    [Fact]
    public void LongitudDNIIncorrecto() 
    {
        Assert.Throws<Exception>(() => new DNI(123456789,'Z'));
        Assert.Throws<Exception>(() => new DNI(1234567,'Z'));
    }
    [Fact]
    public void LetraIncorrecta() 
    {
        Assert.Throws<Exception>(() => new DNI(12345679,'P'));  
        Assert.Throws<Exception>(() => new DNI(12345679,'z'));  
    }
    [Fact]
    public void DNICorrecto() 
    {
        DNI dni = new DNI(12345678,'Z');
        DNI dni2 = new DNI(00000001,'R');
        Assert.Equal("12345678Z",$"{dni.NDni}{dni.LDni}");
        Assert.Equal("00000001R",dni2.ToString().Substring(4));
    }


}