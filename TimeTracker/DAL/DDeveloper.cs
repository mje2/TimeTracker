//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DDeveloper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DDeveloper()
        {
            this.DJobTimings = new HashSet<DJobTiming>();
            this.DJobItems = new HashSet<DJobItem>();
        }
    
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public string DeveloperShortName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DJobTiming> DJobTimings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DJobItem> DJobItems { get; set; }
    }
}
