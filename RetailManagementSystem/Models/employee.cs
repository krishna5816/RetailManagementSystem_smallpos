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
    
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.advances = new HashSet<advance>();
            this.salaries = new HashSet<salary>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string photo { get; set; }
        public string docs { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public Nullable<decimal> salary { get; set; }
        public string email { get; set; }
        public Nullable<int> sync_id { get; set; }
        public Nullable<System.DateTime> lastsync { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<advance> advances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salary> salaries { get; set; }
    }
}
