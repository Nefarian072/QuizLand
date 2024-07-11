using AutoMapper;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.DataTransferObjects.Quiz;
using QuizLand.Infrastructure.Requests.Quizes.Commands;
using QuizLand.Infrastructure.Requests.Quizes.Queries;
using QuizLand.Infrastructure.Responses.Quizes.Commands;
using QuizLand.Infrastructure.Responses.Quizes.Queries;
using QuizLand.WebAPI.Models.QuizModels;
namespace QuizLand.WebAPI.Maps.Quizes;

public class QuizMappingProfile: Profile
{
    public QuizMappingProfile()
    {
        CreateMap<CreateQuizModel, CreateQuizCommand>();
        CreateMap<Quiz, QuizDto>();
        CreateMap<GetQuizModel, GetQuizQuery>().ReverseMap();
        CreateMap<GetQuizModel, GetFirstQuestionQuery>().ReverseMap();
        CreateMap<GetQuizModel, DeleteQuizCommand>().ReverseMap();
        CreateMap<UpdateQuizModel, UpdateQuizCommand>().ReverseMap();
        CreateMap<GetQuizModel, GetQuestionsQuery>().ReverseMap();
        CreateMap<GetQuizModel, UpdateQuizCommand>().ReverseMap();
    }
}
