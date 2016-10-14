namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FootballWeek13Context : DbContext
    {
        public FootballWeek13Context()
            : base("name=FootballWeek13Context")
        {
        }

        public virtual DbSet<Football2> Football2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Football2>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);
        }
    }
}
