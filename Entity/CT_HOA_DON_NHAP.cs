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
    
    public partial class CT_HOA_DON_NHAP
    {
        public int MA_CTHD_NHAP { get; set; }
        public string MA_SP { get; set; }
        public double GIA_NHAP { get; set; }
        public double GIAM_GIA { get; set; }
        public int SO_LUONG { get; set; }
        public double THANH_TIEN { get; set; }
        public int MA_HD_NHAP { get; set; }
    
        public virtual SAN_PHAM SAN_PHAM { get; set; }
        public virtual HOA_DON_NHAP HOA_DON_NHAP { get; set; }
    }
}