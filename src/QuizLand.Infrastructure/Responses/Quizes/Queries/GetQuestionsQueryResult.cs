using QuizLand.DataTransferObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.Infrastructure.Responses.Quizes.Queries;

public class GetQuestionsQueryResult
{
    public IEnumerable<QuestionDto>? Questions { get; set; } = new List<QuestionDto>();
}
