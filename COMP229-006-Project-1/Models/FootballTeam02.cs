namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FootballTeam02
    {
        [Key]
        [StringLength(50)]
        public string TeamName2 { get; set; }

        public int? TeamScore2 { get; set; }

        public int? Spectators2 { get; set; }
    }
}
