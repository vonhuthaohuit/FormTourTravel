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
    
    public partial class chuongtrinhtour
    {
        public long machuongtrinhtour { get; set; }
        public string tieude { get; set; }
        public string ngay { get; set; }
        public string mota { get; set; }
        public long matour { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual tour tour { get; set; }
    }
}
