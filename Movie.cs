using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsoleApp
{
    public class Movie : IMovie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }


        public Movie(string title, string director, int releaseYear)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Title} ({ReleaseYear}), directed by {Director}");
        }
    }
}
