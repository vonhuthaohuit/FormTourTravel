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
    
    public partial class nhanvien
    {
        public nhanvien()
        {
            this.blogtours = new HashSet<blogtour>();
            this.phongbans = new HashSet<phongban>();
            this.phancongchucvus = new HashSet<phancongchucvu>();
            this.phancongnhanviens = new HashSet<phancongnhanvien>();
        }
    
        public long manhanvien { get; set; }
        public string hoten { get; set; }
        public string gioitinh { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public string sodienthoai { get; set; }
        public string bangcap { get; set; }
        public string hinhdaidien { get; set; }
        public Nullable<System.DateTime> ngayvaolam { get; set; }
        public Nullable<bool> tinhtrang { get; set; }
        public Nullable<long> maphongban { get; set; }
        public long mataikhoan { get; set; }
    
        public virtual ICollection<blogtour> blogtours { get; set; }
        public virtual ICollection<phongban> phongbans { get; set; }
        public virtual phongban phongban { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<phancongchucvu> phancongchucvus { get; set; }
        public virtual ICollection<phancongnhanvien> phancongnhanviens { get; set; }
    }
}
