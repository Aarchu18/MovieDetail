using Microsoft.AspNetCore.Mvc;
using MovieDetail.Models.Data;
using System.Collections.Generic;

namespace MovieDetail.Controllers
{
    public class MovieController : Controller
    {

      public static List<MovieList> movieList=MovieData.GetMovieDetail();

        public IActionResult Index()
        {
            return View(movieList);
        }

        public IActionResult SearchById(int id)
        {
            var model = MovieData.GetMovieById(id);

            if(model!=null)
            {
                  return PartialView("_SingleMovieDetailPartial", model);
            }

            return NotFound();

        }

         public IActionResult Insert()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Insert(MovieList movie)
        {
            movieList.Add(new MovieList
            {
                MovieId = movie.MovieId,
                MovieName = movie.MovieName,
                ReleaseYear = movie.ReleaseYear,
                Genere = movie.Genere
            });

           return RedirectToAction("Index", "Movie");
        }

        public IActionResult UpdateMovie()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult UpdateMovie(MovieList movie)
        {
            bool isMovieFound = false;
            foreach (var data in movieList)
            {
                if (data.MovieId == movie.MovieId)
                {
                    isMovieFound = true;
                    data.MovieName = movie.MovieName;
                    data.ReleaseYear = movie.ReleaseYear;
                    data.Genere = movie.Genere;
                }
            }
            if (isMovieFound)
            {
                return RedirectToAction("Index", "Movie");
            }
            return NotFound();
        }

        public IActionResult DeleteMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteMovie(MovieList movie)
        {
            bool isMovieFound = false;
            MovieList movieListData = new MovieList();
            foreach (var data in movieList)
            {
                if (data.MovieId == movie.MovieId)
                {
                    isMovieFound = true;
                    movieListData = data;
                }
            }
            if (isMovieFound)
            {
                movieList.Remove(movieListData);
                return RedirectToAction("Index", "Movie");
            }
            return NotFound();
        }
    }
}