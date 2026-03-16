bool continuer = true;
string choix;

Console.WriteLine("Bonjour voulez vous jouer ? oui/non");
choix = Console.ReadLine();

while (continuer)
{

    if (choix == "non")
    {
        continuer = false;
        break;
    }

    Console.Clear();

    Console.WriteLine("Entrez le nom de joueur 1");
    Joueur j1 = new Joueur(Console.ReadLine());

    Console.WriteLine("Entrez le nom de joueur 2");
    Joueur j2 = new Joueur(Console.ReadLine());

    Console.Clear();

    Deck deck = new Deck(52);
    deck.melangerDeck();
    Game game = new Game(j1, j2, deck);

    game.distribuerCarte();

    for (int i = 1; i <= (deck.nbcarte / 2); i++)
    {
        Console.WriteLine($"{j1.name} : {j1.score} VS {j2.name} : {j2.score}");

        Console.WriteLine($"{j1.deckCarte.Peek().getCarte()} VS {j2.deckCarte.Peek().getCarte()}");

        game.gagnerManche(j1.jouerCarte(), j2.jouerCarte());

        Console.WriteLine("Appuie sur une touche pour continuer");
        Console.ReadLine();

        Console.Clear();
    }

    game.gagnerMatch();

    Console.WriteLine("Voulez vous re jouer ? oui/non");
    choix = Console.ReadLine();
}

Console.WriteLine("Bonjour voulez vous jouer ? oui/non");
choix = Console.ReadLine();
