using BL.Enums;
using BL.Service.Login;
using BL.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ASPMYSQL.Controllers
{
    public class LoginController : Controller
    {
        LoginService loginService;
        public LoginController()
        {
            loginService = new LoginService();
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (!User.Identity.IsAuthenticated)
                return View();
            else 
                return RedirectToAction("Profile", "User");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            //TODO: problema com modelstate: usuario e id nao preenchidos estão dando problema. Talvez criar uma viewmodel?

            if (!ModelState.IsValid)
                return View(model);
            //https://www.youtube.com/watch?v=Fhfvbl_KbWo

            var user = loginService.Login(model);
            if (user != null)
            {
                //criando o cookie de login utilizando a biblioteca Authentication
                //indica informações sobre o usuário que está logando
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("UserType", Enum.GetName(typeof(UserType), user.UserType))
                };

                //cria uma identidade baseada nas informações acima
                var userIdentity = new ClaimsIdentity(claims, "Auth");

                //criando autenticação de acordo com a identidade passada. Pode-se utilizar mais de um tipo de autenticação, como o Facebook
                //coleção de identidades
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                
                //define se o usuário é administrador ou não (se está na role de administrador)
                principal.IsInRole(user.UserType.ToString());
                HttpContext.SignInAsync(principal, new AuthenticationProperties { ExpiresUtc = DateTime.UtcNow.AddMinutes(10) });
                //HttpContext.SignInAsync(principal, new AuthenticationProperties { IsPersistent = true });

                return RedirectToAction("Profile", "User");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Usuário ou senha incorretos.");
                return View(model);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            //apaga o cookie de login e redireciona
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}