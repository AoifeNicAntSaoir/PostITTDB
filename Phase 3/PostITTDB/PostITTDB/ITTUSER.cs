//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostITTDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ITTUSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITTUSER()
        {
            this.POSTs = new HashSet<POST>();
            this.RANKs = new HashSet<RANK>();
        }
    
        public short USERID { get; set; }
        public string FIRSTNAME { get; set; }
        public string SURNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public Nullable<short> SCORE { get; set; }
        public string PROFILEPIC { get; set; }
        public Nullable<short> USERTYPEID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POSTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANK> RANKs { get; set; }
        public virtual USERTYPE USERTYPE { get; set; }
    }
}