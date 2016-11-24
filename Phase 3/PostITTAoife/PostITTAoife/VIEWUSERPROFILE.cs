namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.VIEWUSERPROFILE")]
    public partial class VIEWUSERPROFILE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short USERID { get; set; }

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
        [StringLength(30)]
        public string EMAIL { get; set; }

        public short? SCORE { get; set; }

        [StringLength(50)]
        public string PROFILEPIC { get; set; }
    }
}
