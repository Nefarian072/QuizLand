using Microsoft.EntityFrameworkCore;
using QuizLand.DataLayer.Base.BaseRepository;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.DataLayer.Base.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(QuizLandDbContext context) : base(context)
    {
    }

}
