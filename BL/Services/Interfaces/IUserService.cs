using BL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BL.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserViewModel> GetAll();
        UserViewModel GetById(Guid id);
        UserViewModel GetByEmail(string email);
        ValidationResult Add(UserViewModel model);
        ValidationResult Edit(UserViewModel model);
        ValidationResult Remove(Guid id);
    }
}
