using BL.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IUserDao
    {
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        User Add(User model);
        User Update(User model);
        User Remove(Guid id);
    }
}
