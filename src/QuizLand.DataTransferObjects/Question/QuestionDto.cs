using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.DataTransferObjects.Question;

public class QuestionDto
{
    public int Id { get; set; }
    public string? Text { get; set; }
    public bool Answer { get; set; }
}
