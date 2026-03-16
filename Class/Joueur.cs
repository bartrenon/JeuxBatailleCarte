public class Joueur
{
    public string name;

    public int score = 0;

    public Queue<Carte> deckCarte = new Queue<Carte>();

    public Joueur(string name) 
    {
        this.name = name;
    }

    public Carte jouerCarte()
    {
        return deckCarte.Dequeue();
    }

    public int getScore()
    {
        return this.score;
    }

    public void setScore() 
    {
        this.score++;
    }
    public void getDeck()
    {
        foreach (Carte carte in deckCarte)
        {
            carte.getCarte();
        }
    }
}
