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
    
    public partial class tour_guides
    {
        public decimal id { get; set; }
        public long staff_id { get; set; }
        public long tour_schedules_id { get; set; }
        public string task { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual tour_schedules tour_schedules { get; set; }
    }
}
