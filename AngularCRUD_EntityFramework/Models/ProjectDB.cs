using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularCRUD_EntityFramework.Models
{
    public class ProjectDB:DbContext
    {
        public ProjectDB() //: base("ProjectDB1")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}