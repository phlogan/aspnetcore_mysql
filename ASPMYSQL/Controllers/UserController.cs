using BL.Models;
using DAL.DAO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASPMYSQL.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserDao userDao;
        public UserController()
        {
            userDao = new UserDao();
        }
        public IActionResult Index()
        {
            return null;
        }

        public ActionResult View(Guid id)
        {
            User model = userDao.GetById(id);
            return View(model);
        }
    }
}