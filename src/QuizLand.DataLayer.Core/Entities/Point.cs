using System.ComponentModel.DataAnnotations;

namespace QuizLand.DataLayer.Core.Entities;
public class Point : BaseEntity
{
    public int Count { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public Quiz Quiz { get; set; }
    public int QuizId { get; set; }
}
