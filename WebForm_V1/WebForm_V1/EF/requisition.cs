//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm_V1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class requisition
    {
        public requisition()
        {
            this.outstandings = new HashSet<outstanding>();
            this.requisition_detail = new HashSet<requisition_detail>();
        }
    
        public string requisition_id { get; set; }
        public System.DateTime requisition_date { get; set; }
        public int requisition_made_by { get; set; }
        public string requisition_status { get; set; }
        public string requisition_remark { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual ICollection<outstanding> outstandings { get; set; }
        public virtual ICollection<requisition_detail> requisition_detail { get; set; }
    }
}
