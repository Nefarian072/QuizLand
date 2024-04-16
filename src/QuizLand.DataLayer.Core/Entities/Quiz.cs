using System.ComponentModel.DataAnnotations;

namespace QuizLand.DataLayer.Core.Entities;

public class Quiz : BaseEntity
{
    [Key]
    public new int Id { get; set; }
    public string? Theme { get; set; }

    public string? Description { get; set; }

    public IEnumerable<Question> Questions { get; set; }
    public int QuestionId { get; set; }

    public IEnumerable<User> Users { get; set; }

    public int UserId { get; set; }
}
