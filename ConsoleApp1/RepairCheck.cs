//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class RepairCheck
    {
        public int RepairCheckId { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public Nullable<int> SugesstionPrice { get; set; }
        public int InventoryRefId { get; set; }
    
        public virtual Inventory Inventory { get; set; }
    }
}
