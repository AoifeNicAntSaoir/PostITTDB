namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.VIEWPOSTS")]
    public partial class VIEWPOST
    {
        public short? USERID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SURNAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string POSTTEXT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string POSTTYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string CATEGORYNAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string TAGNAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short POSTRANK { get; set; }
    }
}
