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
    
    public partial class tour_details
    {
        public tour_details()
        {
            this.tour_schedules = new HashSet<tour_schedules>();
        }
    
        public long id { get; set; }
        public long tour_id { get; set; }
        public long tour_place_id { get; set; }
        public string title { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public decimal price { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual tour tour { get; set; }
        public virtual tour_places tour_places { get; set; }
        public virtual ICollection<tour_schedules> tour_schedules { get; set; }
    }
}
