using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace Project.Models
{
    public class User
    {
        public int ID { set; get; }
        [Required(ErrorMessage = "please Enter the Name ")]

        public string Name { set; get;  }
        [Required (ErrorMessage ="please enter the Password")]

        public string Password { set; get;  }
    }
}