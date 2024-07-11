using AutoMapper;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.DataTransferObjects.Question;
using QuizLand.Infrastructure.Requests.Questions.Command;
using QuizLand.WebAPI.Models.QuestionModels;
namespace QuizLand.WebAPI.Maps.Questions;

public class QuestionMappingProfile : Profile
{
    public QuestionMappingProfile()
    {
        CreateMap<Question, QuestionDto>().ReverseMap();
        CreateMap<UpdateQuestionModel,UpdateQuestionCommand>().ReverseMap();
    }
}
