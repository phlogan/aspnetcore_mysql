using BL.ViewModels;

namespace BL.Services.Interfaces
{
    public interface ILoginService
    {
        UserViewModel Login(LoginViewModel login);
        bool Logoff();
        bool IsLogged();

    }
}
