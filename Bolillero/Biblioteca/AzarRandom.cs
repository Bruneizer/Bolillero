using Biblioteca;
public class RandomAzar : IAzar
{
    private Random _random = new Random();
    public int SacarNumero(int maximo)
    {
        return _random.Next(maximo);
    }
}