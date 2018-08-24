using Microsoft.AspNetCore.Mvc;
using MovieDetail.Models.Data;
using System;
using System.Collections.Generic;

namespace MovieDetail.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<MovieList> movieData = GetMovieDetail();

            return View(movieData);
        }
        MovieViewModel movieViewModel = new MovieViewModel();
        List<MovieList> movieDataView;
        public MovieController()
        {
            movieViewModel.MovieList = GetMovieDetail();
            movieDataView = GetMovieDetail();
        }
        public List<MovieList> GetMovieDetail()
        {
            MovieData data = new MovieData();
            return data.GetMovieDetail();
        }

        [HttpPost]
        public IActionResult MovieDetailPartial(MovieList model)
        {
            var movieBindedData = $"{model.MovieId}";
            int movieID = Convert.ToInt32(movieBindedData);
            List<MovieList> movieData = SearchByID(movieID);
            movieViewModel.MovieList = movieData;
            Index();

            return Json(movieBindedData);
        }
        private List<MovieList> SearchByID(int movieBindedData)
        {
            List<MovieList> movieData = new List<MovieList>();
            foreach (MovieList item in movieDataView)
            {
                if (item.MovieId == movieBindedData)
                {
                    movieData.Add(item);
                }
            }
            return movieData;
        }

    }
}