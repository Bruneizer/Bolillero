using Biblioteca;
public class Bolillero
{
    List<int> AdentroBolillero;
    List<int> AfueraBolillero;
    public Azar aazar;
public Bolillero(int cantidad, Azar azar )
{
    AdentroBolillero = Enumerable.Range(0, cantidad).ToList();
    AfueraBolillero = new List<int>();
    aazar = azar;
}
public int SacarBolilla()
{
if(AdentroBolillero.Count == 0)
{
throw new InvalidOperationException("No hay Bolilla adentro del Bolillero");
}
int indice = aazar.Next(AfueraBolillero.Count);
int bolillaSacada = AdentroBolillero[indice];
AdentroBolillero.RemoveAt(indice);
AfueraBolillero.Add(bolillaSacada);
return bolillaSacada;
}
public 




}