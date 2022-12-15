using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AdminLogin.Models
{
    public class AdminContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }    
    }
}