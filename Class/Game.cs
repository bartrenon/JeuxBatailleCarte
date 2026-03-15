public class Game
{
    public Joueur j1;

    public Joueur j2;

    public Queue<Carte> deckCarte;

    public Game(Joueur j1, Joueur j2, Deck d)
    {
        this.j1 = j1;
        this.j2 = j2;

        for (int i = 0; i < d.nbcarte; i++)
        {
            deckCarte.Enqueue(d.deckCarte[i]);
        }
    }

    public void distribuerCarte() 
    {
        for (int i = 0; i < deckCarte.Count(); i++)
        {
            if(i%2 != 0) 
            {
                j1.deckCarte.Enqueue(deckCarte.Dequeue());
            }
            else 
            {
                j2.deckCarte.Enqueue(deckCarte.Dequeue());
            }
        }
    }
}

