using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuizLand.Infrastructure.Responses.Quizes.Commands;

public class CreateQuizCommandResult
{
    public string? Name { get; set; }

    public int CreatorId { get; set; }

    public string? Description { get; set; }

    public string? Theme { get; set; }
}
