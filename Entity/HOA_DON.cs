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
    
    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            this.CT_HOA_DON = new HashSet<CT_HOA_DON>();
        }
    
        public int MA_HD { get; set; }
        public string MA_NV { get; set; }
        public System.DateTime NGAY_BAN { get; set; }
        public Nullable<int> MA_KH { get; set; }
        public double TONG_TIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOA_DON> CT_HOA_DON { get; set; }
        public virtual KHACH_HANG KHACH_HANG { get; set; }
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
