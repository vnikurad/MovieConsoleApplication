namespace MovieConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Movie movie1 = new("The Matrix", "Lana Wachowski", 1999);
            Movie movie2 = new("The Fifth Element", "Luc Besson", 1997);
            Movie movie3 = new("Blade Runner", "Ridley Scott", 1982);

            movie1.PrintInfo();
            movie2.PrintInfo();
            movie3.PrintInfo(); 
            */


            //List<Movie> movies = new List<Movie>()
            //{
            //    new Movie("The Matrix", "Lana Wachowski", 1999),
            //    new Movie("The Fifth Element", "Luc Besson", 1997),
            //    new Movie("Blade Runner", "Ridley Scott", 1982)
            //};

            //foreach (var movie in movies)
            //{
            //    movie.PrintInfo();
            //}

            Console.WriteLine("How many movies do you want to enter?");
            int movieCount = int.Parse(Console.ReadLine());

            //create an array
            Movie[] movies = new Movie[movieCount];

            //input movies
            for(int i = 0; i < movieCount; i++)
            {
                Console.WriteLine($"Enter details for movie N{i + 1}");

                Console.WriteLine("Title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Director: ");
                string director = Console.ReadLine();

                Console.WriteLine("Release Year: ");
                int releaseYear = int.Parse(Console.ReadLine());

                movies[i] = new Movie(title, director, releaseYear);
            }

            //output movies
            Console.WriteLine("\n--- Movie List ---");
            for(int i = 0; i < movies.Length; i++)
            {
                movies[i].PrintInfo();
            }


        }
    }
}
