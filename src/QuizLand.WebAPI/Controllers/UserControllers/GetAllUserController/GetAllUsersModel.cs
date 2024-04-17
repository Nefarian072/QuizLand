using QuizLand.DataLayer.Core.Entities;
namespace QuizLand.WebAPI.Controllers.UserControllers.GetAllUserController;

public class GetAllUsersModel
{
    IEnumerable<User> Users { get; set; }
}
