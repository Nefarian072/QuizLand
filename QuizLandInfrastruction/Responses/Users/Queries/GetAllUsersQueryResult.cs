namespace QuizLandInfrastructure.Responses.Users.Queries;

public class GetAllUsersQueryResult
{
    public string message { get; set; } // либо сообщение о том что пользовтели были успешно получены либо сообщение о том что пользователи не найдены

    //public IEnumerable<User> users { get; set; } есть вариант возвращать список пользователей

}
