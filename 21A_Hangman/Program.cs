// x Man bestämmer ett ord
// x Man skriver ut så många streck som det finns bokstäver i ordet
// - Man gissar en bokstav
// - Kolla om det är rätt eller fel (finns med minst 1 gång i ordet)
//   - Rätt: skriver ut bokstaven på rätt plats
//   - Fel: Man blir av med 1 gissning, ritar ut en till del av gubben
//          Och bokstaven skrivs upp
// - Ny gissning
//   Om inte det står en bokstav på alla streck
//   Eller om man fått slut på gissningar

string word = "banana";

List<string> underscores = new();

for (int i = 0; i < word.Length; i++)
{
  underscores.Add("_");
}

Console.WriteLine(string.Join(" ", underscores));

Console.WriteLine("GISSA");

string guess = "";

while (guess.Length != 1)
{
  guess = Console.ReadLine();
}

Console.WriteLine($"You guessed {guess}!");

Console.ReadLine();