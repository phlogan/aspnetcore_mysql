using BL.Enums;
using BL.Services.Interfaces;
using BL.ViewModels;
using DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public ValidationResult Add(UserViewModel model)
        {
            DAL.Models.User user = new DAL.Models.User();
            user = new DAL.Models.User
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                UserType = (DAL.Enums.UserType)model.UserType
            };
            model.UserId = user.Id;

            var validation = ValidateUser(user);
            if (validation == ValidationResult.Success)
                if (!userDao.Add(user))
                    return new ValidationResult("Não foi possível inserir o usuário. Contate o administrador.");

            return validation;
        }

        public ValidationResult Edit(UserViewModel model)
        {
            DAL.Models.User user = new DAL.Models.User
            {
                Id = model.UserId,
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                UserType = (DAL.Enums.UserType)model.UserType
            };

            var validation = ValidateUser(user);
            if (validation == ValidationResult.Success)
                if (!userDao.Update(user))
                    return new ValidationResult("Não foi possível atualizar o usuário. Contate o administrador.");

            return validation;
        }

        public ValidationResult Remove(Guid id)
        {
            return userDao.Remove(id) ?
                ValidationResult.Success :
                new ValidationResult("Não foi possível remover o usuário.");
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
            if (model != null)
                return new UserViewModel
                {
                    UserId = model.Id,
                    Username = model.Username,
                    Email = model.Email,
                    UserType = (UserType)model.UserType
                };

            return null;
        }

        private ValidationResult ValidateUser(DAL.Models.User user)
        {
            var userByUsername = userDao.GetByUsername(user.Username);
            var userByEmail = userDao.GetByEmail(user.Email);

            if (userByUsername?.Username == user.Username && userByUsername?.Id != user.Id)
                return new ValidationResult("O Nome de Usuário informado já está em uso.");

            if (userByEmail?.Email == user.Email && userByEmail?.Id != user.Id)
                return new ValidationResult("O E-mail informado já está em uso.");

            return ValidationResult.Success;
        }
    }
}
