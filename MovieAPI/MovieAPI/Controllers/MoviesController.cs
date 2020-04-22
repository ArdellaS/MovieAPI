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
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private IDAL dal;
        public MoviesController(IDAL dalObject)
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

       
    }
}
