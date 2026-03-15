public class Game
{
    public Joueur j1;

    public Joueur j2;

    public Queue<Carte> deckCarte;

    public int nbCarte;

    public Game(Joueur j1, Joueur j2, int nbCarte)
    {
        this.j1 = j1;
        this.j2 = j2;
        this.nbCarte = nbCarte;

        this.deckCarte = new Queue<Carte>();
        int[] RandomTab = shuffle(nbCarte);

        foreach (int nb in RandomTab)
        {
            Carte c = new Carte(couleur.nb,valeurs.nb);
            this.deckCarte.Enqueue(c);
        }
    }

    static int[] shuffle(int nbcarte) 
    {
        int[nbcarte] tab;
        Random rnd = new Random();

        for (int i = tab.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(0, i + 1);
            (tab[i], tab[j]) = (tab[j], tab[i]);
        }

        return tab;
    }
}

