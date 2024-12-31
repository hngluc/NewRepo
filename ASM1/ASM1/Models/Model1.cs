using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASM1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=TinhHinh")
        {
        }

        public virtual DbSet<DiaPhuong> DiaPhuongs { get; set; }
        public virtual DbSet<TrangThai> TrangThais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrangThai>()
                .HasMany(e => e.DiaPhuongs)
                .WithRequired(e => e.TrangThai)
                .WillCascadeOnDelete(false);
        }
    }
}
