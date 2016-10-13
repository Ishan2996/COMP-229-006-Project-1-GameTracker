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

        public virtual DbSet<Football1> Football1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Football1>()
                .Property(e => e.TeamName1)
                .IsUnicode(false);
        }
    }
}
