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
    
    public partial class chitietphieudattour
    {
        public long makhachhang { get; set; }
        public long maphieudattour { get; set; }
        public double chitietsotiendat { get; set; }
        public string nguoidat { get; set; }
    
        public virtual khachhang khachhang { get; set; }
        public virtual phieudattour phieudattour { get; set; }
    }
}
