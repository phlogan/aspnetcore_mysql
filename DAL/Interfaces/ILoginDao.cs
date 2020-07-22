using BL.Models;
using System;

namespace DAL.Interfaces
{
    public interface ILoginDao
    {
        bool Login(User model);
        bool Logoff();
        bool IsLogged();

    }
}
