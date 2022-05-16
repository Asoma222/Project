using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;
using System.Data.Entity;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public DataContext db2 = new DataContext(); 
        public ActionResult GetListProduct()
        {
            
            return View(db2.medicines.ToList()); 
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            
            return View(); 
        }
        [HttpPost]
        public ActionResult CreateProduct(medicine medicinemodel)
        {
            if (ModelState.IsValid)
            
            {
                if (!db2.medicines.Any(x => x.Name == medicinemodel.Name && x.contact == medicinemodel.contact))
                {
                    db2.medicines.Add(medicinemodel);
                    db2.SaveChanges();
                    return View(); // now we will work on it 

                }
                else
                {
                    ViewData["message"] = "you enter this product before for the same contact"; 
                }

            }
            
            return View(); 

        }

        [HttpGet]

        public ActionResult EditProduct(int id)
        {
            var MedicinePointer = db2.medicines.Where(model => model.medicineID == id).FirstOrDefault();
            medicine MedicineModel = MedicinePointer;
            db2.medicines.Remove(MedicinePointer); 
            db2.SaveChanges();

            return View(MedicinePointer);  
        }

        [HttpPost] 

        public ActionResult EditProduct(medicine MedicineParameter)
        {
            if (ModelState.IsValid)
            {
                if (!db2.medicines.Any(x => x.Name == MedicineParameter.Name && x.contact == MedicineParameter.contact))
                {
                    db2.medicines.Add(MedicineParameter); 
                    db2.SaveChanges();
                    return RedirectToAction("GetListProduct"); 
                }
                else
                {
                    ViewData["message"] = "you enter this product before for the same contact"; 

                }

            }
            return View(); 
        }

        [HttpGet] 
        public ActionResult DetailsProduct( int ID )
        {
            var MedicinePointer = db2.medicines.Where(Modelmedicine => Modelmedicine.medicineID == ID).FirstOrDefault();
            return View(MedicinePointer);  

        }


        public ActionResult DeleteProduct(int ID )
        {
            var MedicinePointer = db2.medicines.Where(Model => Model.medicineID == ID).FirstOrDefault();
            db2.medicines.Remove(MedicinePointer); 
            db2.SaveChanges(); 
            return RedirectToAction("GetListProduct"); 

        }

    }
}