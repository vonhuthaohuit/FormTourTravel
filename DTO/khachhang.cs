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
    
    public partial class khachhang
    {
        public khachhang()
        {
            this.danhgias = new HashSet<danhgia>();
            this.dattours = new HashSet<dattour>();
            this.diachis = new HashSet<diachi>();
            this.hoadons = new HashSet<hoadon>();
        }
    
        public long id { get; set; }
        public string hoten { get; set; }
        public string gioitinh { get; set; }
        public System.DateTime ngaysinh { get; set; }
        public string sodienthoai { get; set; }
        public string email { get; set; }
        public string hinhdaidien { get; set; }
        public long user_id { get; set; }
    
        public virtual ICollection<danhgia> danhgias { get; set; }
        public virtual ICollection<dattour> dattours { get; set; }
        public virtual ICollection<diachi> diachis { get; set; }
        public virtual ICollection<hoadon> hoadons { get; set; }
        public virtual user user { get; set; }
    }
}
