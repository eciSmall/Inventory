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
    
    public partial class InventoryExpens
    {
        public int ID { get; set; }
        public Nullable<int> InventoryIncome { get; set; }
        public Nullable<int> InventoryTax { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public Nullable<int> InventoryOutcome { get; set; }
        public Nullable<int> InventoryId { get; set; }
    
        public virtual Inventory Inventory { get; set; }
    }
}
