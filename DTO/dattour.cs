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
    
    public partial class dattour
    {
        public long tour_id { get; set; }
        public long khachhang_id { get; set; }
        public long soluong { get; set; }
        public System.DateTime ngaydattour { get; set; }
        public decimal dongia { get; set; }
        public string trangthai { get; set; }
    
        public virtual tour tour { get; set; }
        public virtual khachhang khachhang { get; set; }
    }
}