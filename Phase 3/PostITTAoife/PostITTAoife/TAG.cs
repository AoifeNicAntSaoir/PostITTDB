namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.TAG")]
    public partial class TAG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TAGID { get; set; }

        [Required]
        [StringLength(20)]
        public string TAGNAME { get; set; }

        public short CATEGORYID { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }
    }
}
