using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public interface IDAL
    {
        Film GetRandomMovie();
        IEnumerable<Film> GetAllMovies();
        IEnumerable<Film> GetFilmsByCategory(string category);
        IEnumerable<Film> GetRandomFilmsByCategory(string category);
    }
}
