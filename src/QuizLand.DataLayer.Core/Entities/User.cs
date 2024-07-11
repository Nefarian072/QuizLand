using System.ComponentModel.DataAnnotations;

namespace QuizLand.DataLayer.Core.Entities;

public class User : BaseEntity
{
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public byte[] Password { get; set; }

    public IEnumerable<Point> Points { get; set; }
}
