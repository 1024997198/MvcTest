using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("StudentDbContext")

        {

        }
        public DbSet<Student> Students { get; set; }
    }
}