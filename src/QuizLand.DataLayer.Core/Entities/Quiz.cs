using System.ComponentModel.DataAnnotations;

namespace QuizLand.DataLayer.Core.Entities;

public class Quiz : BaseEntity
{
    public string? Theme { get; set; }
    public string? Name { get; set; }

    public int CreatorId { get; set; }
    public string? Description { get; set; }

    public IEnumerable<Question> Questions { get; set; }
    public IEnumerable<User> Users { get; set; }
}
