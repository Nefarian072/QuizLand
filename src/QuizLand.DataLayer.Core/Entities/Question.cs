using System.ComponentModel.DataAnnotations;

namespace QuizLand.DataLayer.Core.Entities;

public class Question : BaseEntity
{
    public string Text { get; set; }
    public bool Answer { get; set; }

    public Quiz Quiz { get; set; }
    public int QuizId { get; set; }

}
