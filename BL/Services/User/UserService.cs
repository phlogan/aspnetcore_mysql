using BL.Enums;
using BL.Services.Interfaces;
using BL.ViewModels;
using DAL.DAO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BL.Services.User
{
    public class UserService : IUserService
    {
        UserDao userDao;
        public UserService()
        {
            userDao = new UserDao();
        }

        public UserViewModel Add(UserViewModel model)
        {
            DAL.Models.User user = new DAL.Models.User();
            user = new DAL.Models.User
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                UserType = (DAL.Enums.UserType)model.UserType
            };

            //TODO: criar validação para NÃO PERMITIR QUE E-MAIL E USERNAME SE REPITAM
            userDao.Add(user);

            model.UserId = user.Id;

            return model;
        }

        public UserViewModel Edit(UserViewModel model)
        {
            throw new NotImplementedException();
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
            if(model != null)
                return new UserViewModel
                {
                    UserId = model.Id,
                    Username = model.Username,
                    Email = model.Email,
                    UserType = (UserType)model.UserType
                };

            return null;
        }
    }
}
