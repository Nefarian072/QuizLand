using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.Infrastructure.Responses.Quizes.Queries;

public class GetQuizQueryResult
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Theme { get; set; }

    public string? Message { get; set; }
}
