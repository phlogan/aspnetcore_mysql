using BL.Enums;
using BL.Services.User;
using BL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
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

            if (!ModelState.IsValid)
                return View(model);

            ValidationResult validation = userService.Add(model);
            if (validation == ValidationResult.Success)
                return RedirectToAction("View", new { id = model.UserId });

            ModelState.AddModelError("", validation.ErrorMessage);
            return View(model);
        }

        public ActionResult Edit(Guid id)
        {
            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString())
                throw new PrivilegeNotHeldException();

            UserViewModel model = userService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel model)
        {
            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString())
                throw new PrivilegeNotHeldException();

            if (!ModelState.IsValid)
                return View(model);

            ValidationResult validation = userService.Edit(model);
            if (validation == ValidationResult.Success)
                return RedirectToAction("View", new { id = model.UserId });

            ModelState.AddModelError("", validation.ErrorMessage);
            return View(model);
        }

        public ActionResult Remove()
        {
            return null;
        }
        [HttpPost]
        public ActionResult Remove(Guid id)
        {
            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString())
                throw new PrivilegeNotHeldException();
            ValidationResult validation = userService.Remove(id);
            if (validation == ValidationResult.Success)
                return RedirectToAction("List");

            return new BadRequestObjectResult(validation.ErrorMessage);
        }

        public ActionResult View(Guid id)
        {
            UserViewModel model = userService.GetById(id);

            if (User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value != UserType.Admin.ToString()
                && User.Claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value != model.Email)
                throw new PrivilegeNotHeldException();

            ViewBag.CanEdit = User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value == UserType.Admin.ToString();
            ViewBag.CanRemove = User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value == UserType.Admin.ToString();
            ViewBag.CanList = User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value == UserType.Admin.ToString();

            return View(model);
        }

        public ActionResult Profile()
        {
            ViewBag.CanListUsers = User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value == UserType.Admin.ToString();
            ViewBag.CanAddUsers = User.Claims?.FirstOrDefault(c => c.Type == "UserType")?.Value == UserType.Admin.ToString();

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