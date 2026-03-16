public class Game
{
    public Joueur j1;

    public Joueur j2;

    public Queue<Carte> deckCarte = new Queue<Carte>();

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
        int taille = deckCarte.Count;

        for (int i = 0; i < taille; i++)
        {
            if (i % 2 != 0)
            {
                j1.deckCarte.Enqueue(deckCarte.Dequeue());
            }
            else
            {
                j2.deckCarte.Enqueue(deckCarte.Dequeue());
            }
        }
    }

    public void gagnerManche(Carte c1, Carte c2)
    {
        if ((int)c1.valeur > (int)c2.valeur)
        {
            j1.setScore();
            Console.WriteLine($"victoir de {j1.name}");
        }
        else if ((int)c1.valeur < (int)c2.valeur)
        {
            Console.WriteLine($"victoir de {j2.name}");
            j2.setScore();
        }

        Console.WriteLine("égalité");
    }

    public void gagnerMatch()
    {
        if (j1.score > j2.score)
        {
            Console.WriteLine($"victoir de {j1.name} avec {j1.score} sur {j2.score + j1.score} manches");
        }
        else if (j1.score < j2.score)
        {
            Console.WriteLine($"victoir de {j2.name} avec {j2.score} sur {j2.score + j1.score} manches");
        }

        Console.WriteLine("Match null entre les deux joueurs");
    }

    public void getDeck()
    {
        foreach (Carte carte in deckCarte)
        {
            carte.getCarte();
        }
    }
}

