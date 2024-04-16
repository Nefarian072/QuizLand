using Microsoft.EntityFrameworkCore;

namespace QuizLand.WebAPI;

public class QuizLandDbContext : DbContext
{
    public QuizLandDbContext(DbContextOptions<QuizLandDbContext> options) : base(options)
    {

    }
}
