﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTracker.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TimeTrackerEntities : DbContext
    {
        public TimeTrackerEntities()
            : base("name=TimeTrackerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DCustomer> DCustomers { get; set; }
        public virtual DbSet<DDeveloper> DDevelopers { get; set; }
        public virtual DbSet<DJobItem> DJobItems { get; set; }
        public virtual DbSet<DJobTiming> DJobTimings { get; set; }
        public virtual DbSet<DRequestor> DRequestors { get; set; }
        public virtual DbSet<Log4NetLog> Log4NetLog { get; set; }
        public virtual DbSet<DEstimate> DEstimates { get; set; }
    }
}
