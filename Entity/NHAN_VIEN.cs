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
    
    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            this.HOA_DON = new HashSet<HOA_DON>();
            this.HOA_DON_NHAP = new HashSet<HOA_DON_NHAP>();
        }
    
        public string MA_NV { get; set; }
        public string TEN_NV { get; set; }
        public string SDT { get; set; }
        public string DIA_CHI { get; set; }
        public Nullable<bool> GIOI_TINH { get; set; }
        public Nullable<System.DateTime> NGAY_VL { get; set; }
        public string EMAIL { get; set; }
        public string TAI_KHOAN { get; set; }
        public string MAT_KHAU { get; set; }
        public Nullable<byte> CHUC_VU { get; set; }
        public Nullable<byte> TRANG_THAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON_NHAP> HOA_DON_NHAP { get; set; }
    }
}
