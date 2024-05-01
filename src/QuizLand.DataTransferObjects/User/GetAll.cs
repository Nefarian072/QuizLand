namespace QuizLand.DataTransferObjects.User;

public class GetAll
{
    public IEnumerable<UserDto> Users { get; set; } = new List<UserDto>();
}
