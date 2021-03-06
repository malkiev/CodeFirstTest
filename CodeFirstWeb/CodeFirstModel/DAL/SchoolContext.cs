﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstModel.DAL
{
    class SchoolContext:DbContext
    {
        public SchoolContext(): base("SchoolContext")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Enrollment> Enrollments{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
