//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class chitietphuongtientour
    {
        public long matour { get; set; }
        public long maphuongtien { get; set; }
        public long soluonghanhkhach { get; set; }
        public string ghichu { get; set; }
    
        public virtual phuongtien phuongtien { get; set; }
        public virtual tour tour { get; set; }
    }
}
