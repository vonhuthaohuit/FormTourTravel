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
    
    public partial class diemdulich
    {
        public diemdulich()
        {
            this.chitiettours = new HashSet<chitiettour>();
        }
    
        public long id { get; set; }
        public string tendiem { get; set; }
        public string mota { get; set; }
    
        public virtual ICollection<chitiettour> chitiettours { get; set; }
    }
}
