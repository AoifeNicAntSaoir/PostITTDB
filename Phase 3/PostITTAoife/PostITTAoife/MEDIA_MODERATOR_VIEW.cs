namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.MEDIA_MODERATOR_VIEW")]
    public partial class MEDIA_MODERATOR_VIEW
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SURNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string POSTTEXT { get; set; }

        [StringLength(20)]
        public string POSTTYPE { get; set; }

        [StringLength(20)]
        public string CATEGORYNAME { get; set; }

        [StringLength(20)]
        public string TAGNAME { get; set; }

        public short? POSTRANK { get; set; }
    }
}
