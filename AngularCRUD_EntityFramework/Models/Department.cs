﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularCRUD_EntityFramework.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}