using QuizLand.DataTransferObjects.User;

namespace QuizLand.WebAPI.Models.UserModels
{
    public class AllUsers
    {
        public IEnumerable<UserDto> Users { get; set; } = new List<UserDto>();
    }
}
