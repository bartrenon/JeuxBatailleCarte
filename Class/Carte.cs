public class Carte
{
    public Couleurs couleur;

    public Valeurs valeur ;

    public Carte(Couleurs couleur, Valeurs valeur)
    {
        this.couleur = couleur;
        this.valeur = valeur;
    }

    public string getCarte()
    {
        return $"{this.valeur} de {this.couleur}";
    }
}
