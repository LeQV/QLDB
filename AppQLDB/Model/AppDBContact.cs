using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQLDB.Model
{
    public partial class AppDBContact : DbContext
    {
        public AppDBContact()
            : base("name=AppDBContact")
        {
        }

        public virtual DbSet<LienLac> LienLac { get; set; }
        public virtual DbSet<Nhom> Nhom { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LienLac>()
                .Property(e => e.SDT)
                .IsFixedLength();
        }
    }
}
