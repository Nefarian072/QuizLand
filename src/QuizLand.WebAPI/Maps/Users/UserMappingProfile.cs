using AutoMapper;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.DataTransferObjects.User;
using QuizLand.WebAPI.Models.UserModels;
using QuizLandInfrastructure.Requests.Users.Commands;
using QuizLandInfrastructure.Responses.Users.Queries;
namespace QuizLand.WebAPI.Maps.Users;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<CreateUserModel, CreateUserCommand>();
        CreateMap<GetAllUsersQueryResult, AllUsers>().ReverseMap();
        CreateMap<User, UserDto>();
    }
}

