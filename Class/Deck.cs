public class Deck
{
    public int nbcarte;

    public Carte[] deckCarte;
    public Deck(int nbcarte)
    {
        this.nbcarte = nbcarte;
        deckCarte = new Carte[nbcarte];

        int k = 0;

        for (int i = 1; i < 5; i++)
        {
            for (int j = 2; j < 15; j++)
            {
                deckCarte[k] = new Carte((Couleurs)i,(Valeurs)j);
                k++;
            }
        }
    }

    public void melangerDeck()
    {
        Random rnd = new Random();

        for (int i = deckCarte.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(0, i + 1);

            Carte temp = deckCarte[i];
            deckCarte[i] = deckCarte[j];
            deckCarte[j] = temp;
        }
    }

    public void getDeck()
    {
        foreach (Carte carte in deckCarte)
        {
           carte.getCarte();
        }
    }

}
