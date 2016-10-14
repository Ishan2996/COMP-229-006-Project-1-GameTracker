namespace COMP229_006_Project_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Football14
    {
        [Key]
        [StringLength(50)]
        public string TeamName1 { get; set; }

        public int? TeamScore1 { get; set; }

        public int? Spectators1 { get; set; }
    }
}
