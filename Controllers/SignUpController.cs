using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class SignUpController : Controller
    {
        public DataContext db = new DataContext(); 
        // GET: SignUp
        public ActionResult Index()
        {
            return View(db.Users.ToList()) ;
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Signup(User UserParameter)
        {
            if (ModelState.IsValid)
            {

                if(db.Users.Any(x=>x.Name == UserParameter.Name || x.Password == UserParameter.Password)){
                    ViewBag.Notification = "the name is exist or the password is exist";
                    return View(UserParameter); 
                }
                else
                {
                    db.Users.Add(UserParameter);
                    db.SaveChanges();
                   // Session["UserName"] = UserParameter.Name.ToString();
                    //Session["Password"] = UserParameter.Name.ToString();
                    return RedirectToAction("login" , "Login");  

                }
                
            }
            return View(); 
        }

    }
}