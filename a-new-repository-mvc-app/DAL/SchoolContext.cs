using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using a_new_repository_mvc_app.Models;

namespace a_new_repository_mvc_app.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(): base("SchoolContext")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public virtual IEnumerable<Student> GetWithRawSql(string query, params object[] parameters)
        {
           return Students.SqlQuery(query, parameters).ToList();
        }

        

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}