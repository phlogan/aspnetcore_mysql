using Microsoft.AspNetCore.Mvc;
using DAL.DAO;
using BL.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ASPMYSQL.Controllers
{
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

        public ActionResult View()
        {
            //trocar getall por getbyid
            ICollection<User> model = userDao.GetAll();
            return View(model.LastOrDefault());
        }
    }
}