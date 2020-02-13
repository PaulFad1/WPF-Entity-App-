
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace GroupViewer
{
    public class StudentDb: DbContext
    {
        public DbSet<Student> students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            modelBuilder.Configurations.Add(new System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Student>());
        }
        public StudentDb() : base("DefaultConnection") 
        {
            
        }
    }
}
