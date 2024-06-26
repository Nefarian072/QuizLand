﻿using QuizLand.DataLayer.Core.Entities;

namespace QuizLand.DataLayer.Base.Interfaces;

public interface IUserRepository : IRepository<User>
{
    public User? GetByEmail(string email);
}
