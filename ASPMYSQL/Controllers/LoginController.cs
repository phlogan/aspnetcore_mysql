using BL.Enums;
using BL.Service.Login;
using BL.ViewModels;
using Microsoft.AspNetCore.Authentication;
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

            if (!ModelState.IsValid)
                return View(model);

            var user = loginService.Login(model);
            if (user != null)
            {
                //criando o cookie de login utilizando as bibliotecas Authentication e Security
                //indica informações sobre o usuário que está logando
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("UserType", Enum.GetName(typeof(UserType), user.UserType))
                };

                //cria uma identidade baseada nas informações acima
                var userIdentity = new ClaimsIdentity(claims, "Auth");

                //criando autenticação de acordo com a identidade passada. Pode-se utilizar mais de um tipo de autenticação,
                //coleção de identidades
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

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

        public async Task<IActionResult> Logout()
        {
            //apaga o cookie de login
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}