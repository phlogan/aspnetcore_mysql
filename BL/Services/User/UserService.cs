using BL.Enums;
using BL.Services.Interfaces;
using BL.ViewModels;
using DAL.DAO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Services.User
{
    public class UserService : IUserService
    {
        UserDao userDao;
        public UserService()
        {
            userDao = new UserDao();
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            var list = userDao.GetAll();
            list.ToList();
            List<UserViewModel> users = new List<UserViewModel>();
            foreach (DAL.Models.User userModel in list)
            {
                users.Add(new UserViewModel
                {
                    UserId = userModel.Id,
                    Username = userModel.Username,
                    Email = userModel.Email,
                    UserType = (UserType)userModel.UserType,
                });
            }
            return users;
        }

        public UserViewModel GetByEmail(string email)
        {
            var model = userDao.GetByEmail(email);
            return new UserViewModel
            {
                UserId = model.Id,
                Username = model.Username,
                Email = model.Email,
                UserType = (UserType)model.UserType
            };
        }

        public UserViewModel GetById(Guid id)
        {
            var model = userDao.GetById(id);
            return new UserViewModel
            {
                UserId = model.Id,
                Username = model.Username,
                Email = model.Email,
                UserType = (UserType)model.UserType
            };
        }
    }
}
