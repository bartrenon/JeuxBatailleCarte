public class Joueur
{
    public string name;

    public int score = 0;

    public Queue<Carte> deckCarte;

    public int getScore()
    {
        return this.score;
    }

    public void setScore() 
    {
        this.score++;
    }
}
