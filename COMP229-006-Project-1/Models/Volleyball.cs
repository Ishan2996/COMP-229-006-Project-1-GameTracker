namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Volleyball : DbContext
    {
        public Volleyball()
            : base("name=Volleyball1")
        {
        }

        public virtual DbSet<Volleyball12> Volleyball12 { get; set; }
        public virtual DbSet<Volleyball13> Volleyball13 { get; set; }
        public virtual DbSet<Volleyball14> Volleyball14 { get; set; }
        public virtual DbSet<Volleyball15> Volleyball15 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Volleyball12>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Volleyball13>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Volleyball14>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Volleyball15>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);
        }
    }
}
