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
    
    public partial class Chi_Tiet_Don_Hang
    {
        public string Ma_don_hang { get; set; }
        public string Ma_san_pham { get; set; }
        public Nullable<int> So_luong { get; set; }
        public string Gia_ban { get; set; }
        public string Thanh_tien { get; set; }
    
        public virtual Don_Hang Don_Hang { get; set; }
        public virtual San_Pham San_Pham { get; set; }
    }
}
