bool continuer = true;
string choix, nom;


while (continuer)
{
    Console.WriteLine("Bonjour voulez vous jouer ? oui/non");
    Console.ReadLine(choix);

    if(choix == "non") 
    {
        continuer = false;
    }

    Console.WriteLine("Entrez le nom de joueur 1");
    Console.ReadLine(nom);
    Joueur j1 = new Joueur("bart");

    Console.WriteLine("Entrez le nom de joueur 2");
    Console.ReadLine(nom);
    Joueur j2 = new Joueur("léa");

    Deck deck = new Deck(52);
    deck.melangerDeck();
    Game game = new Game(j1, j2, deck);

    game.distribuerCarte;

    for (int = 0; int <= (deck.nbcarte/2); int++)
    {
        game.gagnerManche(j1);
    }

}
