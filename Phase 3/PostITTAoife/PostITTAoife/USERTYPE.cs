namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.USERTYPE")]
    public partial class USERTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERTYPE()
        {
            ITTUSERs = new HashSet<ITTUSER>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short USERTYPEID { get; set; }

        [Required]
        [StringLength(1)]
        public string TYPEDESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITTUSER> ITTUSERs { get; set; }
    }
}
