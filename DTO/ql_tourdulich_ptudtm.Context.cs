﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ql_tourdulich_ptudtmEntities : DbContext
    {
        public ql_tourdulich_ptudtmEntities()
            : base("name=ql_tourdulich_ptudtmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<address> addresses { get; set; }
        public DbSet<book_tours> book_tours { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<department> departments { get; set; }
        public DbSet<district> districts { get; set; }
        public DbSet<failed_jobs> failed_jobs { get; set; }
        public DbSet<hotel> hotels { get; set; }
        public DbSet<migration> migrations { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<password_reset_tokens> password_reset_tokens { get; set; }
        public DbSet<personal_access_tokens> personal_access_tokens { get; set; }
        public DbSet<province> provinces { get; set; }
        public DbSet<rating> ratings { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<schedules_hotels> schedules_hotels { get; set; }
        public DbSet<schedules_transports> schedules_transports { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<tour_cancels> tour_cancels { get; set; }
        public DbSet<tour_details> tour_details { get; set; }
        public DbSet<tour_guides> tour_guides { get; set; }
        public DbSet<tour_images> tour_images { get; set; }
        public DbSet<tour_places> tour_places { get; set; }
        public DbSet<tour_schedules> tour_schedules { get; set; }
        public DbSet<tour_types> tour_types { get; set; }
        public DbSet<tour> tours { get; set; }
        public DbSet<transport> transports { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<ward> wards { get; set; }
    }
}
