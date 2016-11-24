namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.VIEWUSERTYPEPOSTS")]
    public partial class VIEWUSERTYPEPOST
    {
        public short? USERID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string TYPEDESCRIPTION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string FIRSTNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string SURNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string POSTTEXT { get; set; }
    }
}
