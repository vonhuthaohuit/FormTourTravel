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
    
    public partial class tour
    {
        public tour()
        {
            this.chitiettours = new HashSet<chitiettour>();
            this.chuongtrinhtours = new HashSet<chuongtrinhtour>();
            this.dattours = new HashSet<dattour>();
            this.hinhanhtours = new HashSet<hinhanhtour>();
        }
    
        public long id { get; set; }
        public string tentour { get; set; }
        public string motatour { get; set; }
        public string tinhtrang { get; set; }
        public string hinhdaidien { get; set; }
        public string thoigiandi { get; set; }
        public string noikhoihanh { get; set; }
        public long loaitour_id { get; set; }
        public Nullable<System.DateTime> ngaytao { get; set; }
    
        public virtual ICollection<chitiettour> chitiettours { get; set; }
        public virtual ICollection<chuongtrinhtour> chuongtrinhtours { get; set; }
        public virtual ICollection<dattour> dattours { get; set; }
        public virtual ICollection<hinhanhtour> hinhanhtours { get; set; }
        public virtual loaitour loaitour { get; set; }
    }
}