using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.DataLayer.Base.Interfaces;

public interface IRepositoryManager
{
    IUserRepository UserRepository { get; }
    IPointRepository PointRepository { get; }
    IQuizRepository QuizRepository { get; }
    IQuestionRepository QuestionRepository { get; }

}
