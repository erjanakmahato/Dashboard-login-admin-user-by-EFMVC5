using LuminoDashBoard.Models;
using LuminoDashBoard.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuminoDashBoard.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        MvcDBEntities _db = new MvcDBEntities();
        public ActionResult Index()
        {
            List<UserViewModel > lst = new List<UserViewModel>();
            var users = _db.tblUsers.ToList();
            foreach (tblUser item in users)
            {
                lst.Add(new UserViewModel() { UserId = item.UserId, Username = item.Username, Password = item.Password, Fullname = item.Fullname });

            }
            return View(lst );
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}