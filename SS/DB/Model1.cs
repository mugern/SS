using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SS.DB
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Lessons> Lessons { get; set; }
        public virtual DbSet<Rols> Rols { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ClassLesson> ClassLesson { get; set; }
        public virtual DbSet<ApplicationTB> ApplicationTBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Lessons>()
                .HasMany(e => e.ClassLesson)
                .WithRequired(e => e.Lessons)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rols>()
                .Property(e => e.Rols1)
                .IsFixedLength();

            modelBuilder.Entity<Rols>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Rols)
                .WillCascadeOnDelete(false);
        }
    }
}
