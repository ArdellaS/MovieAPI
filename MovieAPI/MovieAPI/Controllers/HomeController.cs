using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MovieAPI.Models;


namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class HomeController : ControllerBase
    {
        private IDAL dal;
        public HomeController(IDAL dalObject)
        {
            dal = dalObject;
        }
        
        [HttpGet]
        public IEnumerable<Film> GetMovies(string category = null)
        {
            if (category == null)
            {
                IEnumerable<Film> movies = dal.GetAllMovies();
                return movies;

            }
            else
            {
                IEnumerable<Film> movies = dal.GetFilmsByCategory(category);
                return movies;

            }
        }

        public Film GetRandomFilm()
        {
            return dal.GetRandomMovie();
        }
        [HttpGet("category")]
        public IEnumerable<Film> RandomCategories(string category)
        {
            IEnumerable<Film> films = dal.GetRandomFilmsByCategory(category);
            return films;
        }

       
    }
}
