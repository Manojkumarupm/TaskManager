//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskInformation
    {
        public int TaskId { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string TaskDescription { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public Nullable<int> IsTaskCompleted { get; set; }
    }
}
