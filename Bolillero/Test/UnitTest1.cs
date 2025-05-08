using Xunit;
using System.Collections.Generic;
using Biblioteca;

public class BolilleroTest
{
    private Bolillero _bolillero;

    public BolilleroTest()
    {
        _bolillero = new Bolillero(10, new Primero());
    }

    [Fact]
    public void SacarBolilla()
    {
        int bolilla = _bolillero.SacarBolilla();
        Assert.Equal(0, bolilla);
        Assert.Equal(9, _bolillero.Dentro.Count);
        Assert.Single(_bolillero.Fuera);
    }

    [Fact]
    public void ReIngresar()
    {
        _bolillero.SacarBolilla();
        _bolillero.ReIngresar();
        Assert.Equal(10, _bolillero.Dentro.Count);
        Assert.Empty(_bolillero.Fuera);
    }

    [Fact]
    public void JugarGana()
    {
        bool gano = _bolillero.Jugar(new List<int> { 0, 1, 2, 3 });
        Assert.True(gano);
    }

    [Fact]
    public void JugarPierde()
    {
        bool gano = _bolillero.Jugar(new List<int> { 4, 2, 1 });
        Assert.False(gano);
    }

    [Fact]
    public void GanarNVeces()
    {
        int veces = _bolillero.JugarNVeces(new List<int> { 0, 1 }, 1);
        Assert.Equal(1, veces);
    }
}