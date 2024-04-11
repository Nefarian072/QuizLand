using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.DataLayer.Base.Repositories;

public class RepositoryManager : IRepositoryManager
{
    protected readonly QuizLandDbContext _context;
    public RepositoryManager(QuizLandDbContext context)
    {
        _context = context;
    }

    public IUserRepository UserRepository => new UserRepository(_context);
    public IQuizRepository QuizRepository => new QuizRepository(_context);
    public IQuestionRepository QuestionRepository => new QuestionRepository(_context);
    public IPointRepository PointRepository => new PointRepository(_context);

}
