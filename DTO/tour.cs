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
    
    public partial class tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tour()
        {
            this.chitietkhachsantours = new HashSet<chitietkhachsantour>();
            this.chitietphuongtientours = new HashSet<chitietphuongtientour>();
            this.chitiettours = new HashSet<chitiettour>();
            this.chuongtrinhtours = new HashSet<chuongtrinhtour>();
            this.hinhanhtours = new HashSet<hinhanhtour>();
            this.phancongnhanviens = new HashSet<phancongnhanvien>();
            this.phieudattours = new HashSet<phieudattour>();
        }
    
        public long matour { get; set; }
        public string tentour { get; set; }
        public string slug { get; set; }
        public string motatour { get; set; }
        public sbyte tinhtrang { get; set; }
        public string hinhdaidien { get; set; }
        public string noikhoihanh { get; set; }
        public string thoigiandi { get; set; }
        public long giatour { get; set; }
        public Nullable<double> giatourgiam { get; set; }
        public long maloaitour { get; set; }
        public Nullable<long> makhuyenmai { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietkhachsantour> chitietkhachsantours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietphuongtientour> chitietphuongtientours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiettour> chitiettours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chuongtrinhtour> chuongtrinhtours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hinhanhtour> hinhanhtours { get; set; }
        public virtual khuyenmai khuyenmai { get; set; }
        public virtual loaitour loaitour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phancongnhanvien> phancongnhanviens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieudattour> phieudattours { get; set; }
    }
}
