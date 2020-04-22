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
    public class RandomController : ControllerBase
    {
        private IDAL dal;
        public RandomController(IDAL dalObject)
        {
            dal = dalObject;
        }
        [HttpGet]
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