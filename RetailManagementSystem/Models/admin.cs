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
    
    public partial class admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public admin()
        {
            this.creditnotes = new HashSet<creditnote>();
            this.creditnoteitems = new HashSet<creditnoteitem>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public Nullable<int> role { get; set; }
        public string email { get; set; }
        public Nullable<int> sync_id { get; set; }
        public Nullable<System.DateTime> lastsync { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creditnote> creditnotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creditnoteitem> creditnoteitems { get; set; }
    }
}
