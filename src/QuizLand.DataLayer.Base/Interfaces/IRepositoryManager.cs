namespace QuizLand.DataLayer.Base.Interfaces;

public interface IRepositoryManager
{
    IUserRepository UserRepository { get; }
    IPointRepository PointRepository { get; }
    IQuizRepository QuizRepository { get; }
    IQuestionRepository QuestionRepository { get; }

    Task Save();

}
