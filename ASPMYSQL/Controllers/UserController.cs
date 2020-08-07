using BL.Enums;
using BL.Services.User;
using BL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.AccessControl;
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

        public ActionResult New()
        {
            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString())
                throw new PrivilegeNotHeldException();

            return View();
        }

        [HttpPost]
        public ActionResult New(UserViewModel model)
        {
            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString())
                throw new PrivilegeNotHeldException();

            model = userService.Add(model);

            return View("View", model.UserId);
        }
        public ActionResult View(Guid id)
        {
            //Buscando o valor do cookie gerado no passo anterior
            //ViewBag.UserTypeClaim = User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value;
            
            UserViewModel model = userService.GetById(id);
            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString() &&
                User.Claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value != model.Email)
                throw new PrivilegeNotHeldException();

            return View(model);
        }

        public ActionResult Profile()
        {
            //pega o valor Email do cookie para pesquisar o usuário
            UserViewModel model = userService.GetByEmail(User.Claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value);
            return View(model);
        }
        public ActionResult List()
        {
            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString())
                throw new PrivilegeNotHeldException();

            var model = userService.GetAll();
            return View(model);
        }
    }
}