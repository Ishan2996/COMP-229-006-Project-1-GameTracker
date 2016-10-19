namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class basketball : DbContext
    {
        public basketball()
            : base("name=basketball")
        {
        }

        public virtual DbSet<Basketball12> Basketball12 { get; set; }
        public virtual DbSet<Basketball13> Basketball13 { get; set; }
        public virtual DbSet<Basketball14> Basketball14 { get; set; }
        public virtual DbSet<Basketball15> Basketball15 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basketball12>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Basketball13>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Basketball14>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Basketball15>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);
        }
    }
}
