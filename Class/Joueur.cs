public class Joueur
{
    public string name { get; };

    public Carte[26] DeckCarte { get; set; };

    public getJoueur()
    {
        Console.WriteLine($"Carte: {name}");
    }
}
