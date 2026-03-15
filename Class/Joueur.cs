public class Joueur
{
    public string name;

    public int score = 0;

    public Carte[] DeckCarte;

    public int getScore()
    {
        return this.score;
    }

    public void setScore() 
    {
        return this.score++;
    }
}
