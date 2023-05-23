namespace filmutleie
{
    internal class FilmRental
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public List<Film> Films { get; private set; }

        public FilmRental(string newName, string newAddress, List<Film> films)
        {
            Name = newName;
            Address = newAddress;
            Films = films;
        }

        public void DisplayAllFilms()
        {
            Console.WriteLine("Films currently in the rentalshop:");
            Console.WriteLine();
            foreach (var film in Films)
            {
                film.DisplayFilmDetails();
            }
        }

        public void AddFilm(Film film)
        {
            Films.Add(film);
        }

        public void RemoveFilm(Film film)
        {
            Films.Remove(film);
        }

        public void ShowByGenre(string genreToFind)
        {
            var findGenre = Films.Where(film => film.Genre == genreToFind);
            foreach (var genre in findGenre)
            {
                genre.DisplayFilmDetails();
            }
        }

        public void SortByYear(int yearToSort)
        {
            var sortedFilms = Films.Where(film => film.ReleaseYear >= yearToSort).OrderBy(film => film.ReleaseYear);
            foreach (var film in sortedFilms)
            {
                film.DisplayFilmDetails();
            }
        }
    }
}