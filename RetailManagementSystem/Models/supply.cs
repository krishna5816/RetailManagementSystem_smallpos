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
    
    public partial class supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supply()
        {
            this.supplyitems = new HashSet<supplyitem>();
        }
    
        public int id { get; set; }
        public Nullable<int> vendor_id { get; set; }
        public Nullable<decimal> transport_cost { get; set; }
        public Nullable<System.DateTime> dates { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> paid { get; set; }
        public Nullable<decimal> due { get; set; }
        public Nullable<int> sync_id { get; set; }
        public Nullable<System.DateTime> lastsync { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string vendorname { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<decimal> grosstotal { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<int> day { get; set; }
        public string bill_num { get; set; }
        public string bill_no { get; set; }
        public Nullable<int> ficialyear_id { get; set; }
    
        public virtual ficialyear ficialyear { get; set; }
        public virtual vendor vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supplyitem> supplyitems { get; set; }
    }
}
