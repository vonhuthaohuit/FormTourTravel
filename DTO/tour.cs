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
            this.book_tours = new HashSet<book_tours>();
            this.tour_details = new HashSet<tour_details>();
            this.tour_images = new HashSet<tour_images>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime start_date { get; set; }
        public bool status { get; set; }
        public string image { get; set; }
        public string time_go { get; set; }
        public string start_place { get; set; }
        public long type_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual ICollection<book_tours> book_tours { get; set; }
        public virtual ICollection<tour_details> tour_details { get; set; }
        public virtual ICollection<tour_images> tour_images { get; set; }
        public virtual tour_types tour_types { get; set; }
    }
}