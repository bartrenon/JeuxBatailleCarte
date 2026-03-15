public class Carte
{
    public Couleurs couleur { get; };

    public Valeurs valeur { get; };

    public getCarte(Valeurs valeur, Couleurs couleur)
    {
        Console.WriteLine($"Carte: {valeur} {couleur}");
    }
}
