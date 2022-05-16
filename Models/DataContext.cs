using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class DataContext :DbContext
    {
        public DbSet<User> Users { set; get; } 
     

        public DbSet<medicine> medicines { set; get;  }

    }
}