namespace Assignment1Oct12017COMP2007.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Party")]
    public partial class Party
    {
        public int PartyId { get; set; }

        [Column("Message ", TypeName = "text")]
        [Required]
        public string Message_ { get; set; }

        [Column("Party Type ")]
        [Required]
        [StringLength(50)]
        public string Party_Type_ { get; set; }

        [Column("Address ")]
        [Required]
        public string Address_ { get; set; }

        public int LocationID { get; set; }

        public virtual PLocation PLocation { get; set; }
    }
}
