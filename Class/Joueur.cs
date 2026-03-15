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
        return deckCarte.Enqueue(d.deckCarte[i]);
    }

    public int getScore()
    {
        return this.score;
    }

    public void setScore() 
    {
        this.score++;
    }
}
