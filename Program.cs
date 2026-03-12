public enum Couleurs 
{
    Coeur = 1,
    Carreau,
    Pique,
    Trefle
} 

public enum Valeurs 
{
   
    Deux = 2,
    Trois,
    Quatre,
    Cinq,
    Six,
    Sept,
    huit,
    Neuf,
    Dix,
    Valet,
    Reine,
    Roi,
    As
}

public struct Carte
{
    public Couleurs Couleur;

    public Valeurs valeur;
}