namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.ITTUSER")]
    public partial class ITTUSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITTUSER()
        {
            POSTs = new HashSet<POST>();
            RANKs = new HashSet<RANK>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short USERID { get; set; }

        [Required]
        [StringLength(20)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string SURNAME { get; set; }

        [Required]
        [StringLength(30)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(30)]
        public string EMAIL { get; set; }

        public short? SCORE { get; set; }

        [StringLength(50)]
        public string PROFILEPIC { get; set; }

        public short? USERTYPEID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POSTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANK> RANKs { get; set; }

        public virtual USERTYPE USERTYPE { get; set; }
    }
}
