﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InvertoryEntities : DbContext
    {
        public InvertoryEntities()
            : base("name=InvertoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeContractKind> EmployeeContractKinds { get; set; }
        public virtual DbSet<EmployeeFault> EmployeeFaults { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<InventoryExpens> InventoryExpenses { get; set; }
        public virtual DbSet<Lorry> Lorries { get; set; }
        public virtual DbSet<OwnProduct> OwnProducts { get; set; }
        public virtual DbSet<OwnProductsList> OwnProductsLists { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<IO_OwnProducts> IO_OwnProducts { get; set; }
        public virtual DbSet<IO_Products> IO_Products { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PartnerRequest> PartnerRequests { get; set; }
        public virtual DbSet<RepairCheck> RepairChecks { get; set; }
        public virtual DbSet<RepairUnit> RepairUnits { get; set; }
    }
}
