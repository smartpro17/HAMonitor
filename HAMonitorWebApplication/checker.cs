//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HAMonitorWebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class checker
    {
        public checker()
        {
            this.tasks = new HashSet<task>();
            this.exec_tasks = new HashSet<exec_tasks>();
        }
    
        public string id_checker { get; set; }
        public string user_id_user { get; set; }
    
        public virtual ICollection<task> tasks { get; set; }
        public virtual ICollection<exec_tasks> exec_tasks { get; set; }
        public virtual user user { get; set; }
    }
}
