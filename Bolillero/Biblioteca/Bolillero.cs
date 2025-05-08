using Biblioteca;
public class Bolillero
{
    private IAzar _azar;

    public List<int> Dentro { get; private set; }
    public List<int> Fuera { get; private set; }

    public Bolillero(int cantidad, IAzar azar)
    {
        _azar = azar;
        Dentro = Enumerable.Range(0, cantidad).ToList();
        Fuera = new List<int>();
    }

    public int SacarBolilla()
    {
        int indice = _azar.SacarNumero(Dentro.Count);
        int bolilla = Dentro[indice];
        Dentro.RemoveAt(indice);
        Fuera.Add(bolilla);
        return bolilla;
    }

    public void ReIngresar()
    {
        Dentro.AddRange(Fuera);
        Fuera.Clear();
    }

    public bool Jugar(List<int> jugada)
    {
        ReIngresar();
        bool gana = true;
        foreach (var numero in jugada)
        {
            int bolilla = SacarBolilla();
            if (bolilla != numero)
            {
                gana = false;
                break;
            }
        }
        return gana;
    }

    public int JugarNVeces(List<int> jugada, int cantidad)
    {
        int aciertos = 0;
        for (int i = 0; i < cantidad; i++)
        {
            if (Jugar(jugada))
                aciertos++;
        }
        return aciertos;
    }
}

