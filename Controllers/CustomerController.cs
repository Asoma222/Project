using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Project.Models;


namespace Project.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public DataContext db = new DataContext(); 
       
        public ActionResult GetListproductForUser()
        {
            
            
            return View(db.medicines.ToList()) ;
        }

        public ActionResult DetailsProduct(int ID )
        {
            var MedicinePointer = db.medicines.Where(ModelMedicine => ModelMedicine.medicineID == ID).FirstOrDefault();
            return View(MedicinePointer);
        }
        

        

    }
}