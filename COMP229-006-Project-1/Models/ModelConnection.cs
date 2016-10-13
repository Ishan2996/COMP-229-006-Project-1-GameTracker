namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelConnection : DbContext
    {
        public ModelConnection()
            : base("name=ModelConnection")
        {
        }

        public virtual DbSet<FootballTeam01> FootballTeam01 { get; set; }
        public virtual DbSet<FootballTeam02> FootballTeam02 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FootballTeam01>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);

            modelBuilder.Entity<FootballTeam02>()
                .Property(e => e.TeamName2)
                .IsUnicode(false);
        }
    }
}
