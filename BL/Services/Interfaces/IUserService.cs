using BL.ViewModels;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace BL.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserViewModel> GetAll();
        UserViewModel GetById(Guid id);
        UserViewModel GetByEmail(string email);
    }
}
