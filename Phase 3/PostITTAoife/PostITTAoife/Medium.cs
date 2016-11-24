namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.MEDIA")]
    public partial class Medium
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MEDIAID { get; set; }

        public short? MEDIATYPEID { get; set; }

        [Required]
        [StringLength(40)]
        public string URL { get; set; }

        [StringLength(1)]
        public string STATUS { get; set; }

        public short? POSTID { get; set; }

        public virtual MEDIATYPE MEDIATYPE { get; set; }

        public virtual POST POST { get; set; }
    }
}
