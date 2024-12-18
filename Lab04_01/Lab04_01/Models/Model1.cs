using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab04_01.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=StudentContextDB")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.AverageScore)
                .HasPrecision(5, 2);
        }
    }
}
