namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.POSTTYPE")]
    public partial class POSTTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POSTTYPE()
        {
            POSTs = new HashSet<POST>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short POSTTYPEID { get; set; }

        [Column("POSTTYPE")]
        [Required]
        [StringLength(20)]
        public string POSTTYPE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POSTs { get; set; }
    }
}
