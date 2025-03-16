namespace SISTEMA_GESTION_ESTUDIANTES_CALIFICACIONES;
using Xunit;
public class PersonaTests
{
    [Fact]
    public void PersonaSinNombre() 
    {
        Persona persona = new Persona(23,43485970,'P');

        Assert.Equal("Desconocido",persona.Nombre);
    }

    [Fact]
    public void ExcepcionEdadFueraDeRango()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Persona("Eduardo", -1, 43485970, 'P'));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Persona("Eduardo", 0, 43485970, 'P'));
    }

}

