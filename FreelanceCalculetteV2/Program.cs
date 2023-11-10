using FreelanceCalculetteV2;

CalculFacture calculFacture = new CalculFacture();
calculFacture.CalculerTotal();
calculFacture.AfficherResultats();

Console.WriteLine("Tapez sur n'importe quelle touche pour quitter l'application.");
Console.ReadLine();