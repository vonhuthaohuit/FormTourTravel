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
    
    public partial class user
    {
        public user()
        {
            this.customers = new HashSet<customer>();
            this.staffs = new HashSet<staff>();
        }
    
        public long id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool status { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public long role_id { get; set; }
        public Nullable<System.DateTime> email_verified_at { get; set; }
        public string remember_token { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual ICollection<customer> customers { get; set; }
        public virtual role role { get; set; }
        public virtual ICollection<staff> staffs { get; set; }
    }
}
