﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetailManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HamroSuperMarketEntities : DbContext
    {
        public HamroSuperMarketEntities()
            : base("name=HamroSuperMarketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<advance> advances { get; set; }
        public virtual DbSet<billitem> billitems { get; set; }
        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<customerpaid> customerpaids { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<expencecategory> expencecategories { get; set; }
        public virtual DbSet<expence> expences { get; set; }
        public virtual DbSet<ficialyear> ficialyears { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<salary> salaries { get; set; }
        public virtual DbSet<salesreturnitem> salesreturnitems { get; set; }
        public virtual DbSet<salesreturn> salesreturns { get; set; }
        public virtual DbSet<supplieradvance> supplieradvances { get; set; }
        public virtual DbSet<supplierpaid> supplierpaids { get; set; }
        public virtual DbSet<supply> supplies { get; set; }
        public virtual DbSet<supplyitem> supplyitems { get; set; }
        public virtual DbSet<variance> variances { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
    }
}
