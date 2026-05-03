using Microsoft.AspNetCore.Mvc;

namespace TP_MODUL10_103022300012.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static List<Film> films = new List<Film>
        {
            new Film(1, "Inception", "Christopher Nolan", 2010, "Sci-Fi", 9.0),
            new Film(2, "Interstellar", "Christopher Nolan", 2014, "Sci-Fi", 8.7),
            new Film(3, "Parasite", "Bong Joon-ho", 2019, "Thriller", 8.6)
        };

        [HttpGet]
        public ActionResult<List<Film>> GetAllFilms()
        {
            return Ok(films);
        }

        [HttpGet("{index}")]
        public ActionResult<Film> GetFilmByIndex(int index)
        {
            return Ok(films[index]);
        }

        [HttpPost]
        public ActionResult AddFilm([FromBody] Film film)
        {
            films.Add(film);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteFilm(int index)
        {
            films.RemoveAt(index);
            return Ok();
        }
    }
}