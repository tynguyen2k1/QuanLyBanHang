//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class DANH_MUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC()
        {
            this.SAN_PHAM = new HashSet<SAN_PHAM>();
        }
    
        public string Ma_DM { get; set; }
        public string TEN_DM { get; set; }
        public string MO_TA { get; set; }
        public Nullable<byte> TRANG_THAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAN_PHAM> SAN_PHAM { get; set; }
    }
}
