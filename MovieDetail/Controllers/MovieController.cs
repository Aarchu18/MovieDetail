
using Microsoft.AspNetCore.Mvc;
using MovieDetail.Models.Data;
using System.Collections.Generic;
using System;

namespace MovieDetail.Controllers
{
    public class MovieController : Controller
    {
        MovieViewModel movieViewModel = new MovieViewModel();
        List<MovieList> movieListModel;
        public IActionResult Index()
        {
            return View(movieViewModel);
        }
        public MovieController()
        {
            movieViewModel.MoviesList = GetMovieDetail();
            movieListModel = GetMovieDetail();
        }
        public List<MovieList> GetMovieDetail()
        {
            MovieData data = new MovieData();
            return data.GetMovieDetail();
        }

        [HttpPost]
        public IActionResult Index(MovieViewModel model)
        {
            var movieBindedData = $"{model.MovieId}";
            int movieId = Convert.ToInt32(movieBindedData);
            List<MovieList> movieData = SearchById(movieId);
            movieViewModel.MoviesList = movieData;
            Index();
            return Json(movieViewModel);
        }
        public List<MovieList> SearchById(int movieBindedData)
        {
            List<MovieList> movieData = new List<MovieList>();
            foreach (MovieList data in movieListModel)
            {
                if (data.MovieId == movieBindedData)
                {
                    movieData.Add(data);
                }
            }
            return movieData;
        }

    }
}