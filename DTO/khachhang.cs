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
            this.chitietphieudattours = new HashSet<chitietphieudattour>();
            this.danhgias = new HashSet<danhgia>();
        }
    
        public long makhachhang { get; set; }
        public string hoten { get; set; }
        public string cccd { get; set; }
        public string gioitinh { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public string diachi { get; set; }
        public string sodienthoai { get; set; }
        public string hinhdaidien { get; set; }
        public Nullable<long> maloaikhachhang { get; set; }
        public Nullable<long> mataikhoan { get; set; }
    
        public virtual ICollection<chitietphieudattour> chitietphieudattours { get; set; }
        public virtual ICollection<danhgia> danhgias { get; set; }
        public virtual loaikhachhang loaikhachhang { get; set; }
        public virtual user user { get; set; }
    }
}
