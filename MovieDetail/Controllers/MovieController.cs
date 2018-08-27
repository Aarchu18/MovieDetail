﻿using Microsoft.AspNetCore.Mvc;
using MovieDetail.Models.Data;

namespace MovieDetail.Controllers
{
    public class MovieController : Controller
    {
        
       
        public IActionResult Index()
        {
            var model = MovieData.GetMovieDetail();
            return View(model);
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

            return RedirectToAction("Insert", "Movie");
        }
        public IActionResult UpdateMovie()
        {
            return View();
        }

    }
}