using BL.Enums;
using BL.Models;
using DAL.DAO;
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
        UserDao userDao;
        LoginDao loginDao;
        public LoginController()
        {
            userDao = new UserDao();
            loginDao = new LoginDao();
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(User model)
        {
            //TODO: problema com modelstate: usuario e id nao preenchidos estão dando problema. Talvez criar uma viewmodel?
            if (!ModelState.IsValid)
                return View(model);
            if (loginDao.Login(model))
            {
                //criando o cookie de login utilizando a biblioteca Authentication

                //indica informações sobre o usuário que está logando
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, model.Email),
                    new Claim(ClaimTypes.Name, model.Username),
                    new Claim("UserType", Enum.GetName(typeof(UserType), model.UserType)),
                };
                
                //cria uma identidade baseada nas informações acima
                var userIdentity = new ClaimsIdentity(claims, "Auth");
                
                //criando autenticação de acordo com a identidade passada. Pode-se utilizar mais de um tipo de autenticação, como o Facebook
                //coleção de identidades
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties();
                
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();

                return RedirectToAction("View", "User", new { id = model.Id });
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

        //[HttpPost]
        //public ActionResult Login(User model)
        //{
        //    //TODO: criar viewmodels
        //    //TODO: CRIAR COOKIES PARA LOGIN (https://medium.com/@lucas.eschechola/autentica%C3%A7%C3%A3o-via-identity-no-asp-net-core-2-2-2a4eb468a8a5)
        //    if (!ModelState.IsValid)
        //        return View(model);
        //    if(loginDao.Login(model))
        //    {
        //        var claims = new List<Claim>()
        //        {
        //            new Claim(ClaimTypes.Email, model.Email),
        //        };
        //        var userIdentity = new ClaimsIdentity(claims, "login");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

        //         HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "Home");
        //    }else
        //    {
        //        ModelState.AddModelError(string.Empty, "Usuário ou senha incorretos.");
        //        return View(model);
        //    }
        //}
    }
}
