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
    
    public partial class loaitour
    {
        public loaitour()
        {
            this.tours = new HashSet<tour>();
        }
    
        public long maloaitour { get; set; }
        public string tenloai { get; set; }
    
        public virtual ICollection<tour> tours { get; set; }
    }
}
