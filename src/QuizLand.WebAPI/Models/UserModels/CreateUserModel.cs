namespace QuizLand.WebAPI.Models.UserModels;
//не особо уверен что входная модель должна быть в папке контроллера, но пока оставлю так.
public class CreateUserModel
{
    public string Name { get; set; }

    public string Email { get; set; }

    public byte[] Password { get; set; }
}
