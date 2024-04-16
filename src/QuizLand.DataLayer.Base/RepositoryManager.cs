using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Base.Repositories;
using QuizLand.WebAPI;

namespace QuizLand.DataLayer.Base;

public class RepositoryManager : IRepositoryManager
{
    private readonly QuizLandDbContext _context;
    private readonly IUserRepository _userRepository;
    private readonly IQuizRepository _quizRepository;
    private readonly IQuestionRepository _questionRepository;
    private readonly IPointRepository _pointRepository;

    public RepositoryManager(QuizLandDbContext context)
    {
        _context = context;
        _userRepository = new UserRepository(_context);
        _quizRepository = new QuizRepository(_context);
        _questionRepository = new QuestionRepository(_context);
        _pointRepository = new PointRepository(_context);
    }

    public async Task Save() => await _context.SaveChangesAsync();

    public IUserRepository UserRepository => _userRepository;

    public IPointRepository PointRepository => _pointRepository;

    public IQuizRepository QuizRepository => _quizRepository;

    public IQuestionRepository QuestionRepository => _questionRepository;
}
