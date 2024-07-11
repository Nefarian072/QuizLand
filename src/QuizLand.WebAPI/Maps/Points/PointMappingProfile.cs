using QuizLand.Infrastructure.Requests.Points.Commands;
using QuizLand.WebAPI.Models.PointModels;
using AutoMapper;

namespace QuizLand.WebAPI.Maps.Points;

public class PointMappingProfile : Profile
{
    public PointMappingProfile()
    {
        CreateMap<RateTheAnswerModel, RateTheAnswerCommand>().ReverseMap();
    }
}
