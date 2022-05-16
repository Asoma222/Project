using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Project.Models; 

namespace Project.Controllers
{

    public class AdminController : Controller
    {
      //  public User globaluser = null ; 
        public DataContext db2 = new DataContext();
        // GET: Admin
        public ActionResult IndexList()
        {
             return View(db2.Users.ToList());
                   
        }
        [HttpGet]
        public ActionResult CreateUser()
        {
            return View(); 
        }
        [HttpPost] 
        public ActionResult CreateUser(User UserParameter)
        {
            if (ModelState.IsValid)
            {

                if (db2.Users.Any(x => x.Name == UserParameter.Name || x.Password == UserParameter.Password))
                {
                    ViewBag.Notification = "the name is exist or the password is exist";
                    return View(UserParameter);
                }
                else
                {
                    db2.Users.Add(UserParameter);
                    db2.SaveChanges();
                
                   

                }

            }
            return View();
        }

       
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var user = db2.Users.Where(u => u.ID == ID).FirstOrDefault();
            User UserToView = user;
            db2.Users.Remove(user);
            db2.SaveChanges(); 
             
            
            return View(UserToView); 
        }

        [HttpPost] 
        public ActionResult Edit(User UserParameter)
        {
            if (ModelState.IsValid)
            {
                
                if (db2.Users.Any(x => x.Name == UserParameter.Name || x.Password == UserParameter.Password))
                {
                    ViewBag.Notification = "the name is exist or the password is exist";
                    return View(UserParameter);
                }
                else
                {
                    db2.Users.Add(UserParameter);
                    db2.SaveChanges();
                    // Session["UserName"] = UserParameter.Name.ToString();
                    //Session["Password"] = UserParameter.Name.ToString();
                    return RedirectToAction("IndexList");

                }

            }


            return View(); 
        }


      [HttpGet]
        public ActionResult Details(int ID)
        {
            var user = db2.Users.Where(u => u.ID == ID).FirstOrDefault();
            return View(user); 

        }
        public ActionResult Delete(int ID )
        {
            User deleteUser = db2.Users.Find(ID);
            db2.Users.Remove(deleteUser); // it will not return View you must ca
            db2.SaveChanges(); 
            return RedirectToAction("IndexList"); 
        }



    }
}