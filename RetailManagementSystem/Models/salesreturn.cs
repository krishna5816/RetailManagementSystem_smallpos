//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class salesreturn
    {
        public int id { get; set; }
        public Nullable<decimal> grosstotal { get; set; }
        public Nullable<decimal> due { get; set; }
        public Nullable<decimal> nettotal { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> returnss { get; set; }
        public Nullable<int> salesreturnitem_id { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> sync_at { get; set; }
    
        public virtual salesreturnitem salesreturnitem { get; set; }
    }
}
