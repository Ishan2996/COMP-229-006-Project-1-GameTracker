namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Hockey : DbContext
    {
        public Hockey()
            : base("name=Hockey1")
        {
        }

        public virtual DbSet<Hockey12> Hockey12 { get; set; }
        public virtual DbSet<Hockey13> Hockey13 { get; set; }
        public virtual DbSet<Hockey14> Hockey14 { get; set; }
        public virtual DbSet<Hockey15> Hockey15 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
        }
    }
}
