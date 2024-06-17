using AutoMapper;
using GameReview.DTO.GameDTO;
using GameReview.Interfaces;
using GameReview.Model.Game;
using Microsoft.AspNetCore.Mvc;

namespace GameReview.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GameController(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Game>))]
        public IActionResult GetGames()
        {
            var game = _mapper.Map<List<GameDTO>>(_gameRepository.GetGame());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            return Ok(game);
        }


        [HttpGet("{gameId}")]
        [ProducesResponseType(200, Type = typeof(Game))]
        [ProducesResponseType(400)]

        public IActionResult GetGame(int gameId)
        {
            if (!_gameRepository.GameExists(gameId))
                return NotFound();

            var gamerev = _mapper.Map<GameDTO>(_gameRepository.GetGame(gameId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(gamerev);
        }

        [HttpGet("{gameId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]

        public IActionResult GetGameRating(int gameId)
        {
            if (!_gameRepository.GameExists(gameId))
                return NotFound();

            var rating = _gameRepository.GetGameRating(gameId);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(rating);
        }
    }
}
