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
    
    public partial class transport
    {
        public transport()
        {
            this.schedules_transports = new HashSet<schedules_transports>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual ICollection<schedules_transports> schedules_transports { get; set; }
    }
}
