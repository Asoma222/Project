using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Project.Models
{
    public class medicine
    {

        public int medicineID { get; set; }
        [Required(ErrorMessage = "you must enter the name of the medicine ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "you must enter the cost of the medicine ")]
        public string Cost { get; set; }
        [Required(ErrorMessage = "you must enter the contact of the pharmacy")]
        [RegularExpression("^[0-9]{1,12}$", ErrorMessage = "Contact must be numeric")]
        public string contact { get; set; }
    }
}