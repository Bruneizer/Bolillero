using Biblioteca;
public class AzarRandom : Azar
{
    Random random = new Random();
    public int ObtenerSiguiente(int maximo)    
    {
        return random.Next(maximo);
    }
    
}
