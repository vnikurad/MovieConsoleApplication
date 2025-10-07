namespace MovieConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("The Matrix", "Lana Wachowski", 1999);
            Movie movie2 = new Movie("The Fifth Element", "Luc Besson", 1997);
            Movie movie3 = new Movie("Blade Runner", "Ridley Scott", 1982);            

            movie1.PrintInfo();
            movie2.PrintInfo();
            movie3.PrintInfo();


            /*List<Movie> movies = new List<Movie>()
            {
                new Movie("The Matrix", "Lana Wachowski", 1999),
                new Movie("The Fifth Element", "Luc Besson", 1997)
            };

            foreach (var movie in movies)
            {
                movie.PrintInfo();
            }*/

        }
    }
}
