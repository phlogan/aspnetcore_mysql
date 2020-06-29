﻿using BL.Models;
using System.Collections;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IUserDao
    {
        ICollection<User> GetAll();
        User GetById();
        User Add();
        User Update();
        User Remove();
    }
}