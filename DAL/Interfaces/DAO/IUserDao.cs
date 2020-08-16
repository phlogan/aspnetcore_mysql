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
        User GetByUsername(string username);
        bool Add(User model);
        bool Update(User model);
        bool Remove(Guid id);
    }
}
