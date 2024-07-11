using System.ComponentModel.DataAnnotations;

namespace QuizLand.DataLayer.Core.Entities;

public class BaseEntity : IEntity
{
    [Key]
    public int Id { get; set; }
}
