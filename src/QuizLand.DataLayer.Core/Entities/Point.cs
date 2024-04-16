using System.ComponentModel.DataAnnotations;

namespace QuizLand.DataLayer.Core.Entities;
public class Point : BaseEntity
{
    [Key]
    public new int Id { get; set; }

    public int Count { get; set; }
    public int UsertId { get; set; }
    public IEnumerable<User> Users { get; set; }
    public int QuizId { get; set; }
    public IEnumerable<Quiz> Quizzes { get; set; }
}
