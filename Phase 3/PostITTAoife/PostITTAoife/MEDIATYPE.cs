namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.MEDIATYPE")]
    public partial class MEDIATYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDIATYPE()
        {
            MEDIA = new HashSet<Medium>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MEDIATYPEID { get; set; }

        [Required]
        [StringLength(20)]
        public string MEDIATYPEDESC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medium> MEDIA { get; set; }
    }
}
