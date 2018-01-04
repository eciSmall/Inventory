using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.UI.Web.Models
{
    public class InvertoryViewModel
    {
        public Model.InventoryModel InventoryModel { get; set; }
        public List<Model.InventoryModel> InventoriesList = new List<Model.InventoryModel>();
        public RepairCheck RepairCheckModel { get; set; }
        public List<RepairCheck> RepairCheckList = new List<Model.RepairCheck>();
        public RepairUnit RepairUnit;
        public List<RepairUnit> RepairUnitList;
        public List<InventoryExpenses> InvertoryExpensesList;
        public InventoryExpenses InvertoryExpenses;
        public Lorry Lorry;
        public List<Lorry> LorryList;
        public List<CargoTransmission> CargoTransmissionList;
        public CargoTransmission CargoTransmission;
        public ProductModel ProductModel;
        public List<ProductModel> ProductsList;
        public OwnProduct OwnProduct { get; set; }
        public List<OwnProduct> OwnProductsList { get; set; }
        public OwnProductsDetails OwnProductsDetails { get; set; }
        public List<OwnProductsDetails> OwnProductsDetailsList { get; set; }
        public Employee Employee { get; set; }
        public List<Employee> EmployeesList { get; set; }
        public EmployeeContractKind EmployeeContractKind { get; set; }
        public EmployeeFault EmployeeFault { get; set; }
        public PartnerRequest PartnerRequest { get; set; }
    }
}