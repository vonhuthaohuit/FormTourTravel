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
    
    public partial class chitiettour
    {
        public System.DateTime ngaybatdau { get; set; }
        public System.DateTime ngayketthuc { get; set; }
        public long giachitiettour { get; set; }
        public long matour { get; set; }
        public long madiemdulich { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual diemdulich diemdulich { get; set; }
        public virtual tour tour { get; set; }
    }
}