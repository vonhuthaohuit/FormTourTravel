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
    
    public partial class phuongtien
    {
        public phuongtien()
        {
            this.chitietphuongtientours = new HashSet<chitietphuongtientour>();
        }
    
        public long maphuongtien { get; set; }
        public string tenphuongtien { get; set; }
        public int sochongoi { get; set; }
        public string sodienthoai { get; set; }
        public long giaphuongtien { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual ICollection<chitietphuongtientour> chitietphuongtientours { get; set; }
    }
}
