using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;
using System.Data.Entity;
namespace Project.Controllers
{
    public class LoginController : Controller
    {
        public DataContext db2 = new DataContext(); 
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult login()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult login(User userparameter)
        {
            var CheckLogin = db2.Users.Where(x=> x.Name.Equals(userparameter.Name) && x.Password.Equals(userparameter.Password)).FirstOrDefault();
            if(CheckLogin != null)
            {
               if(userparameter.Name.ToString() == "admin" && userparameter.Password.ToString() == "admin")
                {
                   return  RedirectToAction("IndexList", "Admin"); 
                }
                else
                {
                    return RedirectToAction("GetListproductForUser", "Customer"); 
                    
                }
                 
            }
            else
            {
                ViewData["message"] = "there's something Wroing the name or the password";
            }
            
            return View(); 

        }

    } 
}