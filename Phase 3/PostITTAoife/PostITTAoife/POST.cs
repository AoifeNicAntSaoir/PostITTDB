namespace PostITTAoife
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AOIFESAYERS.POST")]
    public partial class POST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POST()
        {
            MEDIA = new HashSet<Medium>();
            POST1 = new HashSet<POST>();
            RANKs = new HashSet<RANK>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short POSTID { get; set; }

        public short? PARENTID { get; set; }

        public DateTime? POSTDATE { get; set; }

        [Required]
        [StringLength(50)]
        public string POSTTEXT { get; set; }

        public short? USERID { get; set; }

        public short? POSTTYPEID { get; set; }

        public short? CATEGORYID { get; set; }

        public short? MEDIAID { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }

        public virtual ITTUSER ITTUSER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medium> MEDIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POST1 { get; set; }

        public virtual POST POST2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANK> RANKs { get; set; }

        public virtual POSTTYPE POSTTYPE { get; set; }
    }
}
