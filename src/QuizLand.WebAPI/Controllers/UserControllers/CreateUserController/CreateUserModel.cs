using System.ComponentModel.DataAnnotations;

namespace QuizLand.WebAPI.Controllers.UserControllers.CreateUserController;
//не особо уверен что входная модель должна быть в папке контроллера, но пока оставлю так.
public class CreateUserModel
{

    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public byte[] Password { get; set; }
}
