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
    
    public partial class phieudattour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phieudattour()
        {
            this.chitietphieudattours = new HashSet<chitietphieudattour>();
            this.hoadons = new HashSet<hoadon>();
        }
    
        public long maphieudattour { get; set; }
        public long matour { get; set; }
        public System.DateTime ngaydattour { get; set; }
        public Nullable<System.DateTime> ngaybatdau { get; set; }
        public string trangthaidattour { get; set; }
        public int tongsoluong { get; set; }
        public string nguoidaidien { get; set; }
        public double tongtienphieudattour { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietphieudattour> chitietphieudattours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadon> hoadons { get; set; }
        public virtual tour tour { get; set; }
    }
}
