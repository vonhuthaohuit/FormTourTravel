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
    
    public partial class phongban
    {
        public phongban()
        {
            this.nhanviens = new HashSet<nhanvien>();
        }
    
        public long maphongban { get; set; }
        public string tenphongban { get; set; }
        public long truongphong { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual nhanvien nhanvien { get; set; }
        public virtual ICollection<nhanvien> nhanviens { get; set; }
    }
}
