using BL.Services.User;
using BL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASPMYSQL.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserService userService;
        public UserController()
        {

        }

        public IActionResult Index()
        {
            return null;
        }

        public ActionResult View(Guid id)
        {
            UserViewModel model = userService.GetById(id);
            return View(model);
        }
    }
}