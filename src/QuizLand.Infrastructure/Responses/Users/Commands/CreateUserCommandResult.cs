namespace QuizLandInfrastructure.Responses.Users.Commands;

public class CreateUserCommandResult
{
    public bool IsSuccess => UserName != null && ErrorMessage == null;
    public string? UserName { get; set; } // думаю в качестве ответа можно возвращать только имя пользователя, сформировать как ответ типа "Пользователь {UserName} успешно создан"
    public string? ErrorMessage { get; set; }
}
