using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IUserDao
    {
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        User GetByEmail(string email);
        User Add(User model);
        User Update(User model);
        User Remove(Guid id);
    }
}
