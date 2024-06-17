using AutoMapper;
using GameReview.DTO.GameDTO;
using GameReview.IRepository;
using GameReview.Model.Game;
using Microsoft.AspNetCore.Mvc;

namespace GameReview.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        public GenreController(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Game>))]

        public IActionResult GetGenres()
        {
            var games = _mapper.Map<List<GenreDTO>>(_genreRepository.GetGenres());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(games);
        }

        [HttpGet("{genreId}")]
        [ProducesResponseType(200, Type = typeof(Genre))]
        [ProducesResponseType(400)]

        public IActionResult GetGenre(int genreId)
        {
            if (!_genreRepository.GenreExists(genreId))
                return NotFound();

            var genre = _mapper.Map<GenreDTO>(_genreRepository.GetGenre(genreId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(genre);
        }

        [HttpGet("game/{genreId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Genre>))]
        [ProducesResponseType(400)]
        public IActionResult GetGameByGenreId(int genreId)
        {
            var games = _mapper.Map<List<GameDTO>>(
                _genreRepository.GetGameByGenre(genreId));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(games);
        }
    }

    
}
