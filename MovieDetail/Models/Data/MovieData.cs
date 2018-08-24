using System.Collections.Generic;

namespace MovieDetail.Models.Data
{
    public class MovieData
    {
        public List<MovieList> GetMovieDetail()
        {
           return new List<MovieList>
           {
               new MovieList
               {
                   MovieId = 1,
                   MovieName = "3 idiot",
                   ReleaseYear = "2009",
                   Genere = "Drama"


               },
               new MovieList
               {
                   MovieId = 2,
                   MovieName = "Chandni Chowk To Chaina",
                   ReleaseYear = "2009",
                   Genere = "Action"


               },
               new MovieList
               {
                   MovieId = 3,
                   MovieName = "Luck",
                   ReleaseYear = "2009",
                   Genere = "Action Thriller"


               },
               new MovieList
               {
                    MovieId = 4,
                    MovieName = "The Last Song",
                    ReleaseYear = "2010",
                    Genere = "Romantic Drama"


               },
               new MovieList
               {
                    MovieId = 5,
                    MovieName ="Mission Impossible",
                    ReleaseYear = "2018",
                    Genere = "Action Spy"


               },

           };
        }
    }
}
