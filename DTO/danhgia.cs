//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class danhgia
    {
        public long madanhgia { get; set; }
        public string noidung { get; set; }
        public long diemdanhgia { get; set; }
        public long makhachhang { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<int> matour { get; set; }
        public Nullable<int> tinhtrang { get; set; }
    
        public virtual khachhang khachhang { get; set; }
    }
}