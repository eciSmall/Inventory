using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.UI.Web.Models
{
    public class InvertoryViewModel
    {
        public Model.Inventory InventoryModel { get; set; }
        public List<Model.Inventory> InventoriesList = new List<Model.Inventory>();
        public Model.RepairCheck RepairCheckModel { get; set; }
        public List<Model.RepairCheck> RepairCheckList = new List<Model.RepairCheck>();
        public RepairUnit RepairUnit;
        public List<RepairUnit> RepairUnitList;
        public List<InvertoryExpenses> InvertoryExpensesList;
        public InvertoryExpenses InvertoryExpenses;
        public Lorry Lorry;
        public List<Lorry> LorryList;
        public List<CargoTransmission> CargoTransmissionList;
        public CargoTransmission CargoTransmission;
    }
}