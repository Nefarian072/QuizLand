﻿using QuizLand.DataLayer.Base.BaseRepository;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;

namespace QuizLand.DataLayer.Base.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(QuizLandDbContext context) : base(context)
    {
    }
    public User? GetByEmail(string email)
    {
        return _context.Users.FirstOrDefault(u => u.Email == email);
    }
}
