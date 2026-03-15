public class Carte
{
    public Couleurs couleur;

    public Valeurs valeur ;

    public Carte(Couleurs couleur, Valeurs valeur)
    {
        this.couleur = couleur;
        this.valeur = valeur;
    }

    public void getCarte()
    {
        Console.WriteLine($"{this.valeur} : {this.couleur}");
    }
}
