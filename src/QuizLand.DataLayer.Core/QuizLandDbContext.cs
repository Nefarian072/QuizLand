using Microsoft.EntityFrameworkCore;
using QuizLand.DataLayer.Core.Entities;
namespace QuizLand.WebAPI;

public class QuizLandDbContext : DbContext
{
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Point> Points { get; set; }
    public DbSet<User> Users { get; set; }
    public QuizLandDbContext(DbContextOptions<QuizLandDbContext> options) : base(options)
    {
        
    }
}
