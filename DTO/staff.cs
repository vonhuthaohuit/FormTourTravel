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
    
    public partial class staff
    {
        public staff()
        {
            this.tour_guides = new HashSet<tour_guides>();
        }
    
        public long id { get; set; }
        public string diploma { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<System.DateTime> date_of_entry { get; set; }
        public long user_id { get; set; }
        public long depart_id { get; set; }
        public string fullname { get; set; }
        public string sex { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string image { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual department department { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<tour_guides> tour_guides { get; set; }
    }
}