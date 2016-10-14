namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FootballWeek15 : DbContext
    {
        public FootballWeek15()
            : base("name=FootballWeek15")
        {
        }

        public virtual DbSet<Football15> Football15 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Football15>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);
        }
    }
}
