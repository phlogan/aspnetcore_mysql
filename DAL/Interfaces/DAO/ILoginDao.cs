using DAL.Models;

namespace DAL.Interfaces
{
    public interface ILoginDao
    {
        User Login(User model);
        bool Logoff();
        bool IsLogged();
    }
}
