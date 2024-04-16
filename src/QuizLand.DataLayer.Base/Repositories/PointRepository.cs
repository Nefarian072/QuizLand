using QuizLand.DataLayer.Base.BaseRepository;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;

namespace QuizLand.DataLayer.Base.Repositories;

public class PointRepository : BaseRepository<Point>, IPointRepository
{
    public PointRepository(QuizLandDbContext context) : base(context)
    {
    }
}