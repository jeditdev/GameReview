using AutoMapper;
using GameReview.DTO.GameDTO;
using GameReview.Model.Game;

namespace GameReview.MappingProfile
{
    public class GameMappingProfile : Profile
    {
        public GameMappingProfile()
        {
            CreateMap<Game, GameDTO>();
            CreateMap<Genre, GenreDTO>();
            CreateMap<GenreDTO, Genre>();
        }

    }
}
