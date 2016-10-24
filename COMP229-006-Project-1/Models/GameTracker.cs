namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameTracker : DbContext
    {
        public GameTracker()
            : base("name=GameTrackerContext")
        {
        }

        public virtual DbSet<Basketball12> Basketball12 { get; set; }
        public virtual DbSet<Basketball13> Basketball13 { get; set; }
        public virtual DbSet<Basketball14> Basketball14 { get; set; }
        public virtual DbSet<Basketball15> Basketball15 { get; set; }
        public virtual DbSet<Football12> Football12 { get; set; }
        public virtual DbSet<Football13> Football13 { get; set; }
        public virtual DbSet<Football14> Football14 { get; set; }
        public virtual DbSet<Football15> Football15 { get; set; }
        public virtual DbSet<Hockey12> Hockey12 { get; set; }
        public virtual DbSet<Hockey13> Hockey13 { get; set; }
        public virtual DbSet<Hockey14> Hockey14 { get; set; }
        public virtual DbSet<Hockey15> Hockey15 { get; set; }
        public virtual DbSet<Volleyball12> Volleyball12 { get; set; }
        public virtual DbSet<Volleyball13> Volleyball13 { get; set; }
        public virtual DbSet<Volleyball14> Volleyball14 { get; set; }
        public virtual DbSet<Volleyball15> Volleyball15 { get; set; }

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

            modelBuilder.Entity<Football12>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Football13>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Football14>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Football15>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Hockey12>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Hockey13>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Hockey14>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<Hockey15>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

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
