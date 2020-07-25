using BL.Enums;
using BL.Services.Interfaces;
using BL.ViewModels;
using DAL.DAO;
using DAL.Models;
using System;

namespace BL.Service.Login
{
    public class LoginService : ILoginService
    {
        LoginDao loginDao;
        public LoginService()
        {
            loginDao = new LoginDao();
        }

        public bool IsLogged()
        {
            throw new NotImplementedException();
        }

        public UserViewModel Login(LoginViewModel login)
        {
            User user = new User()
            {
                Email = login.Email,
                Password = login.Password
            };
            user = loginDao.Login(user);
            if (user != null)
            {
                return new UserViewModel
                {
                    UserId = user.Id,
                    Email = user.Email,
                    Username = user.Username,
                    UserType = (UserType)Convert.ToInt32(user.UserType)
                };
            }
            return null;
        }

        public bool Logoff()
        {
            throw new NotImplementedException();
        }
    }
}
