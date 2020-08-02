using BL.Services.User;
using BL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace ASPMYSQL.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserService userService;
        public UserController()
        {
            userService = new UserService();
        }

        public IActionResult Index()
        {
            return null;
        }

        public ActionResult View(Guid id)
        {
            //Buscando o valor do cookie gerado no passo anterior
            ViewBag.UserTypeClaim = User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value;
            UserViewModel model = userService.GetById(id);
            
            return View(model);
        }

        public ActionResult Profile()
        {
            //pega o valor Email do cookie para pesquisar o usuário
            UserViewModel model = userService.GetByEmail(User.Claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value);
            return View(model);
        }
    }
}