using OnlinePlatform.BLL.Concrete;
using OnlinePlatform.DAL.Concrete;
using OnlinePlatform.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlinePlatform.MVC.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new UserRepository());
        BasketManager basketManager = new BasketManager(new BasketRespository());
        #region Login 
        [HttpGet]
        [Route("User/SignOut")]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("User/SignUp")]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("User/SignUp")]
        public ActionResult SignUp(User user)
        {
            if (user != null)
            {
                user.CreatedDate = DateTime.Now;
                user.CreatedUserID = 1;
                userManager.Add(user);
                return RedirectToAction("Login", "User");
            }
            else
            {
                ViewBag.userinfo = "user1".ToUpper();
                ViewBag.userdata = "data";
                return View(user);
            }

        }
        [HttpGet]
        [Route("User/Login")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("User/Login")]
        public ActionResult Login(User user)
        {
            if (string.IsNullOrEmpty(user.NickName) && string.IsNullOrEmpty(user.Password))
            {
                ViewBag.userinfo = "user1".ToUpper();
                ViewBag.userdata = "data";
                return View(user);
            }
            else
            {
                List<User> _user = userManager.GetAll(u => u.NickName == user.NickName && u.Password == user.Password);
                if (_user.Count > 0)
                {
                    foreach (var item in _user)
                    {
                        Session["UserID"] = item.Id;
                        Session["NameSurname"] = item.UserName + " " + item.UserSurName;
                        break;
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    ViewBag.userinfo = "user1".ToUpper();
                    ViewBag.userdata = "";
                    return View(user);
                }
            }
        }
        #endregion
    }
}