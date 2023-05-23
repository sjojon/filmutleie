namespace filmutleie
{
    internal class Film
    {
        public string Title { get; private set; }
        public string Director { get; private set; }
        public int ReleaseYear { get; private set; }
        public string Genre { get; private set; }

        public Film(string newTitle, string newDirector, int newReleaseYear, string newGenre)
        {
            Title = newTitle;
            Director = newDirector;
            ReleaseYear = newReleaseYear;
            Genre = newGenre;
        }

        public void DisplayFilmDetails()
        {
            Console.WriteLine(
                $"Title: {Title}\nDirector: {Director}\nRelease Year: {ReleaseYear}\nGenre: {Genre}\n");
        }
    }
}