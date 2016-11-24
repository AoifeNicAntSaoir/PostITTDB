namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.RANK")]
    public partial class RANK
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short RANKID { get; set; }

        public short POSTRANK { get; set; }

        public short USERID { get; set; }

        public short? POSTID { get; set; }

        public virtual ITTUSER ITTUSER { get; set; }

        public virtual POST POST { get; set; }
    }
}
