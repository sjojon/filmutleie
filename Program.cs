using filmutleie;

/*
Lag en klasse som representerer et filmutleiefirma. Klassen skal ha følgende egenskaper:

1. Navn (string)
2. Adresse (string)
3. En liste over filmer (List<Film>)

Lag også en klasse som representerer en film. Denne klassen skal ha følgende egenskaper:

1. Tittel (string)
2. Regissør (string)
3. Utgivelsesår (int)
4. Sjanger (string)

Implementer følgende funksjonalitet i filmutleiefirma-klassen:

1. En metode som legger til en film i listen over filmer.
2. En metode som fjerner en film fra listen over filmer, basert på tittelen på filmen.
3. En metode som returnerer en liste over alle filmer fra en bestemt sjanger.
4. En metode som returnerer en liste over alle filmer som ble utgitt etter et gitt år.

Du kan bruke denne oppgaven som utgangspunkt for å øve på objektorientert programmering og 
håndtering av klasser og metoder. Du kan utvide funksjonaliteten eller tilpasse den etter behov.
 */

FilmRental filmRental = new("Larvik filmsenter", "Nansetgata 156", new List<Film>());

filmRental.AddFilm(new Film("Spider-Man: No Way Home", "Jon Watts", 2021, "Action"));
filmRental.AddFilm(new Film("Die Hard", "John McTiernan", 1988, "Action"));
filmRental.AddFilm(new Film("Eragon", "Stefen Fangmeier", 2006, "Fantasy"));


//filmRental.Films.Add(new Film("Die Hard", "John McTiernan", 1988, "Action"));
//filmRental.Films.Add(new Film("Eragon", "Stefen Fangmeier", 2006, "Fantasy"));
//filmRental.Films.Add(new Film("Spider-Man: No Way Home", "Jon Watts", 2021, "Action, Adventure"));

filmRental.DisplayAllFilms();

Console.WriteLine("Enter a genre:");
string genreToShow = Console.ReadLine();
filmRental.ShowByGenre(genreToShow);

Console.WriteLine("Enter a year:");
int yearToShow = int.Parse(Console.ReadLine());
filmRental.SortByYear(yearToShow);