//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phieu_Nhap_Kho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Nhap_Kho()
        {
            this.Chi_Tiet_Phieu_Nhap = new HashSet<Chi_Tiet_Phieu_Nhap>();
        }
    
        public string Ma_phieu { get; set; }
        public string Ma_nguoi_dung { get; set; }
        public Nullable<System.DateTime> Ngay_tao { get; set; }
        public string Tongtien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chi_Tiet_Phieu_Nhap> Chi_Tiet_Phieu_Nhap { get; set; }
        public virtual Nguoi_Dung Nguoi_Dung { get; set; }
    }
}
