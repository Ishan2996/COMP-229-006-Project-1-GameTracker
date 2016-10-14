namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FootballWeek14 : DbContext
    {
        public FootballWeek14()
            : base("name=FootballWeek14")
        {
        }

        public virtual DbSet<Football14> Football14 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Football14>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);
        }
    }
}
