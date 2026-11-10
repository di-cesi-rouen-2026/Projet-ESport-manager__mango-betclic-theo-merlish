string nomDuJoueur;

Console.WriteLine("Bienvenue dans notre jeu Esport Manager !");
Console.WriteLine("Le jeu ou vous aller créer et diriger votre propre structure Esport pour bâtir un véritable empire");
Console.WriteLine();
Console.WriteLine("Comment vous appelez vous ?");

nomDuJoueur = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nomDuJoueur))
{
    nomDuJoueur = "Joueur 1";
}
Console.WriteLine ($"Bienvenue dans la folle aventure d'Esport Manager {nomDuJoueur} !!");
Console.WriteLine("VSY");



