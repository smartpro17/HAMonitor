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
    
    public partial class alert
    {
        public string id_alert { get; set; }
        public string type { get; set; }
        public Nullable<System.DateTime> begin_datetime { get; set; }
        public System.DateTime end_datetime { get; set; }
        public string alert_history_id_histo_alert { get; set; }
    
        public virtual exec_tasks exec_tasks { get; set; }
        public virtual alert_history alert_history { get; set; }
    }
}
