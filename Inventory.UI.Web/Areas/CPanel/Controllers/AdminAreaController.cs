using Inventory.Model;
using Inventory.UI.Web.General.Attributes;
using Inventory.UI.Web.Models;
using Invertory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.CPanel.Controllers
{
    
    //[AuthorizeAdmin]
    public class AdminAreaController : BaseCPanelController
    {
        EmployeeLogic employeeLogic = new EmployeeLogic();
        InventoryLogic inventoryLogic = new InventoryLogic();
        ProductLogic productLogic = new ProductLogic();
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Invertory()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.InventoryModel = new Model.InventoryModel()
            {
                Address = "tehran",
                City = "tehran",
                Foundation = 132,
                Name = "gol",
                RepairCondition = true,
                PhoneNumber = "0212222",
                State = "tehran",
                Representation = false
            };
            return View(InvertoryViewModel);
        }
        public ActionResult InvertoriesList(List<Model.InventoryModel> invertoriesLsit)
        {
            InvertoryViewModel = new InvertoryViewModel();           
            InvertoryViewModel.InventoriesList = inventoryLogic.InventoryList();
            return View(InvertoryViewModel);
        }
        public ActionResult RepairCheckList(string name)
        {
            Random random = new Random();
            int randomPrice = random.Next(10000, 152825288);
            Model.RepairCheck repairCheck = new Model.RepairCheck()
            {
                SugesstionPrice = randomPrice,
                VisitDate = DateTime.Now,
            };
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.RepairCheckList.Add(repairCheck);
            InvertoryViewModel.InventoryModel = new Model.InventoryModel()
            {
                Name = name,
            };
            return View(InvertoryViewModel);
        }
        public ActionResult RepairUnitList()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.RepairUnit = new RepairUnit()
            {
                Name = "تعمیر سقف عسگری",
                PhoneNumber = "568484"
            };
            InvertoryViewModel.RepairUnitList = new List<RepairUnit>();
            InvertoryViewModel.RepairUnitList.Add(InvertoryViewModel.RepairUnit);
            return View(InvertoryViewModel);
        }
        public ActionResult RepairUnit()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.RepairUnit = new RepairUnit()
            {
                Name = "تعمیر سقف عسگری",
                PhoneNumber = "568484"
            };
            return View(InvertoryViewModel);
        }
        public ActionResult InvertoryExpensesList(string name)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.InvertoryExpenses = new InventoryExpenses()
            {
                InvertoryIncome = 211,
                Outcome = 163,
                Tax = 15,
                Year = DateTime.Now
            };
            InvertoryViewModel.InvertoryExpensesList = new List<InventoryExpenses>();
            InvertoryViewModel.InvertoryExpensesList.Add(InvertoryViewModel.InvertoryExpenses);
            InvertoryViewModel.InventoryModel = new Model.InventoryModel();
            InvertoryViewModel.InventoryModel.Name = name;
            return View(InvertoryViewModel);
        }

        public ActionResult AddInventory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddInventory(InventoryModel inventoryModel)
        {
            var requestResult = inventoryLogic.Add(inventoryModel);
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.ProductModel = new ProductModel()
            {
                EndUserMessage = requestResult.EndUserMessage,
                Status = requestResult.Status
            };
            return View(InvertoryViewModel);
        }

        public ActionResult InventoryUpdatePage(InventoryModel inventoryModel)
        {
            return View(inventoryModel);
        }

        [HttpPost]
        public ActionResult InventoryUpdate(InventoryModel inventoryModel)
        {
            return View(inventoryModel);
        }
        public ActionResult AddInvertoryExpenses(string name)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.InventoriesList =  inventoryLogic.InventoryNameList();
            InvertoryViewModel.InventoryModel = new Model.InventoryModel();
            InvertoryViewModel.InventoryModel.Name = name;
            return View(InvertoryViewModel);
        }

        [HttpPost]
        public ActionResult AddInvertoryExpenses(InventoryExpenses invertoryExpenses, string name, string _year)
        {
            invertoryExpenses.Year = Convert.ToDateTime(_year);
            var requestResult = inventoryLogic.AddInventoryExpenses(invertoryExpenses);
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.InvertoryExpenses = new InventoryExpenses();
            InvertoryViewModel.InventoryModel = new Model.InventoryModel();
            InvertoryViewModel.InventoryModel.Name = name;
            InvertoryViewModel.InvertoryExpenses.EndUserMessage = requestResult.EndUserMessage;
            return View(InvertoryViewModel);
        }

        public ActionResult PartnersList()
        {
            PartnerViewModel = new PartnerViewModel();
            PartnerViewModel.PartnersList = new List<Partner>();
            PartnerViewModel.PartnersList.Add(new Partner
            {
                Name = "واردات عطر فرخی",
                Address = "اونجا",
                PhoneNumber = "656456",
            });
            return View(PartnerViewModel);
        }

        public ActionResult AddPartner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPartner(Partner partner)
        {
            PartnerViewModel = new PartnerViewModel();
            PartnerViewModel.PartnerModel = new Partner()
            {
                EndUserMessage = "با موفقیت اضافه شد" 
            };
            return View(PartnerViewModel);
        }

        public ActionResult AddLorry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLorry(Lorry lorry)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.Lorry = new Lorry()
            {
                EndUserMessage = "با موفقیت اضافه شد"
            };
            return View(PartnerViewModel);
        }

        public ActionResult LorryList()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.LorryList = new List<Lorry>();
            InvertoryViewModel.LorryList.Add(new Lorry()
            {
                LorryKind = "Cc12",
                Plate = "ffsc23"
            });
            return View(InvertoryViewModel);
        }
        public ActionResult Lorry()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.LorryList = new List<Lorry>();
            InvertoryViewModel.LorryList.Add(new Lorry()
            {
                LorryKind = "Cc12",
                Plate = "ffsc23"
            });
            return View(InvertoryViewModel);
        }
        public ActionResult CargoTransmissionList()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.CargoTransmissionList = new List<CargoTransmission>();
            InvertoryViewModel.CargoTransmissionList.Add(new CargoTransmission()
            {
                Destination = "تهران",
                Origin = "اهواز",
            });
            return View(InvertoryViewModel);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(ProductModel productModel, string _Opening, string _Expiration)
        {
            productModel.Opening = Convert.ToDateTime(_Opening);
            productModel.Expiration = Convert.ToDateTime(_Expiration);
            var requestResult = productLogic.AddProduct(productModel);
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.ProductModel = new ProductModel()
            {
                EndUserMessage = requestResult.EndUserMessage,
                Status = requestResult.Status
            };
            return View(InvertoryViewModel);
        }

        public ActionResult ProductsList()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.ProductsList = new List<ProductModel>();
            InvertoryViewModel.ProductsList.Add(new ProductModel()
            {
                Name = "خربزه",
                Opening = DateTime.Now,
                Expiration = DateTime.Now,
                Price = "1111",
                Source = "Tehran",
                Destination = "Keshmir",
                ProductNumber = 100
            });
            return View(InvertoryViewModel);
        }

        public ActionResult AddOwnProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOwnProduct(OwnProduct ownProduct)
        {
            var requestResult = productLogic.AddOwnProduct(ownProduct);
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.OwnProduct = new OwnProduct()
            {
                EndUserMessage = requestResult.EndUserMessage
            };
            return View(InvertoryViewModel);
        }

        public ActionResult OwnProductsList()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.OwnProductsDetailsList = new List<OwnProductsDetails>();
            InvertoryViewModel.OwnProductsDetailsList.Add(new OwnProductsDetails()
            {
                ProductNumber = 100,
                Source = "rash",
                Destination = "bandar zanzalil"
            });
            InvertoryViewModel.OwnProduct = new OwnProduct()
            {
                Name = "کلم"
            };
            return View(InvertoryViewModel);
        }

        public ActionResult AddOwnProductsDetails()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.OwnProductsList = new List<OwnProduct>();
            InvertoryViewModel.OwnProductsList.Add(new OwnProduct()
            {
                Name = "خودکار",
            });
            InvertoryViewModel.OwnProductsList.Add(new OwnProduct()
            {
                Name = "فوتبال دستی",
            });
            InvertoryViewModel.OwnProduct = new OwnProduct()
            {
                Kind = "Name",
            };
            return View(InvertoryViewModel);
        }

        [HttpPost]
        public ActionResult AddOwnProductsDetails(OwnProductsDetails ownProductsDetails)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.OwnProductsDetails = new OwnProductsDetails()
            {
                EndUserMessage = "با موفقیت اضافه شد"
            };
            return View(InvertoryViewModel);
        }

        public ActionResult IOProducts()
        {
            return View();
        }
        public ActionResult Employee(Employee employee)
        {
            return View(employee);
        }
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee, string birthDay)
        {
            employee.BirthDay = Convert.ToDateTime(birthDay);
            var requestResult = employeeLogic.Add(employee);
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.Employee = new Employee()
            {
                EndUserMessage = requestResult.EndUserMessage,
                Status = requestResult.Status
            };
            return View(InvertoryViewModel);
        }
        public ActionResult IO_Products()
        {
            return View();
        }
        public ActionResult IO_OwnProducts()
        {
            return View();
        }
        public ActionResult EmployeeisList()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.EmployeesList = employeeLogic.EmployeeList();
            return View(InvertoryViewModel);
        }
        public ActionResult EmployeeContract()
        {
            return View();
        }
        public ActionResult EmployeeContractkind()
        {
            return View();
        }

        public ActionResult AddEmployeeContractKind()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployeeContractKind(EmployeeContractKind employeeContractKind)
        {
            var requestResult = employeeLogic.AddEmployeeContractKind(employeeContractKind);
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.EmployeeContractKind = new EmployeeContractKind()
            {
                EndUserMessage = requestResult.EndUserMessage,
                Status = requestResult.Status
            };
            return View(InvertoryViewModel);
        }

        public ActionResult EmployeePaymentStatus()
        {
            return View();
        }
        public ActionResult EmployeePresenceStatus()
        {
            return View();
        }
        public ActionResult EmployeeRequest()
        {
            return View();
        }
        public ActionResult EmployeeFaultList()
        {
            return View();
        }
        public ActionResult AddEmployeeFault()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployeeFault(EmployeeFault employeeFault)
        {
            var requestResult = employeeLogic.AddEmployeeFault(employeeFault);
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.EmployeeFault = new EmployeeFault()
            {
                EndUserMessage = requestResult.EndUserMessage,
                Status = requestResult.Status
            };
            return View(InvertoryViewModel);
        }

        public ActionResult StorageShed()
        {
            return View();
        }
        public ActionResult PartnerRequest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PartnerRequest(PartnerRequest partnerRequest)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.PartnerRequest = new PartnerRequest()
            {
                EndUserMessage = "با موفقیت اضافه شد"
            };
            return View(PartnerViewModel);
        }
        public ActionResult YouNotAccess()
        {
            return View();
        }
    }
}