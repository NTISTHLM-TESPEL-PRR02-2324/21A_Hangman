// x Man bestämmer ett ord
// x Man skriver ut så många streck som det finns bokstäver i ordet
// x Man gissar en bokstav
// - Kolla om det är rätt eller fel (finns med minst 1 gång i ordet)
//   - Rätt: skriver ut bokstaven på rätt plats
//   - Fel: Man blir av med 1 gissning, ritar ut en till del av gubben
//          Och bokstaven skrivs upp
// - Ny gissning
//   Om inte det står en bokstav på alla streck
//   Eller om man fått slut på gissningar

string word = "banana";
int guesses = 7;

List<string> underscores = MakeUnderscores(word);

// while (string.Join("", underscores) != word)

while (underscores.Contains("_") && guesses > 0)
{
  Console.WriteLine($"Du har {guesses} gissingar kvar");
  Console.WriteLine(string.Join(" ", underscores));

  // -- Hämta in en gissning
  Console.WriteLine("GISSA");

  string guess = GimmeGuess();

  if (word.Contains(guess))
  {
    for (int i = 0; i < word.Length; i++)
    {
      if (word[i].ToString() == guess)
      {
        underscores[i] = guess;
      }
    }
  }
  else
  {
    guesses--;
  }

}

Console.WriteLine("GRATZ");

Console.ReadLine();

static List<string> MakeUnderscores(string word)
{
  List<string> underscores = new();

  for (int i = 0; i < word.Length; i++)
  {
    underscores.Add("_");
  }

  return underscores;
}

static string GimmeGuess()
{
  string guess = "";

  while (guess.Length != 1)
  {
    guess = Console.ReadLine();
  }

  return guess;
}