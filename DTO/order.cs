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
    
    public partial class order
    {
        public order()
        {
            this.tour_cancels = new HashSet<tour_cancels>();
        }
    
        public long id { get; set; }
        public Nullable<decimal> total_amount { get; set; }
        public bool status { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public string payment_method { get; set; }
        public Nullable<System.DateTime> create_bill_date { get; set; }
        public long book_tour_id { get; set; }
        public long customer_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual book_tours book_tours { get; set; }
        public virtual customer customer { get; set; }
        public virtual ICollection<tour_cancels> tour_cancels { get; set; }
    }
}
