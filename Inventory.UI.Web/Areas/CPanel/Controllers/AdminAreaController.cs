using Inventory.Model;
using Inventory.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.CPanel.Controllers
{
    public class AdminAreaController : BaseCPanelController
    {
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Invertory()
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.InventoryModel = new Model.Inventory()
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
        public ActionResult InvertoriesList(List<Model.Inventory> invertoriesLsit)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InventoryModel = new Model.Inventory()
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
            InvertoryViewModel.InventoriesList.Add(InventoryModel);
            InventoryModel = new Model.Inventory()
            {
                Address = "rasht",
                City = "rasht",
                Foundation = 555,
                Name = "Jangal",
                RepairCondition = false,
                PhoneNumber = "5478549568",
                State = "rasht",
                Representation = true
            };
            InvertoryViewModel.InventoriesList.Add(InventoryModel);
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
            InvertoryViewModel.InventoryModel = new Model.Inventory()
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
        //AddNewRepair
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
            InvertoryViewModel.InvertoryExpenses = new InvertoryExpenses()
            {
                InvertoryIncome = 211,
                Outcome = 163,
                Tax = 15,
                Year = DateTime.Now
            };
            InvertoryViewModel.InvertoryExpensesList = new List<InvertoryExpenses>();
            InvertoryViewModel.InvertoryExpensesList.Add(InvertoryViewModel.InvertoryExpenses);
            InvertoryViewModel.InventoryModel = new Model.Inventory();
            InvertoryViewModel.InventoryModel.Name = name;
            return View(InvertoryViewModel);
        }
        public ActionResult AddInvertoryExpenses(string name)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.InventoryModel = new Model.Inventory();
            InvertoryViewModel.InventoryModel.Name = name;
            return View(InvertoryViewModel);
        }

        [HttpPost]
        public ActionResult AddInvertoryExpenses(InvertoryExpenses invertoryExpenses, string name)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.InvertoryExpenses = new InvertoryExpenses();
            InvertoryViewModel.InventoryModel = new Model.Inventory();
            InvertoryViewModel.InventoryModel.Name = name;
            InvertoryViewModel.InvertoryExpenses.EndUserMessage = "Added Successful";
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
        public ActionResult AddProduct(ProductModel productModel)
        {
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.ProductModel = new ProductModel()
            {
                EndUserMessage = "با موفقیت اضافه شد"
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
            InvertoryViewModel = new InvertoryViewModel();
            InvertoryViewModel.OwnProduct = new OwnProduct()
            {
                EndUserMessage = "با موفقیت اضافه شد"
            };
            return View(InvertoryViewModel);
        }

        public ActionResult OwnProductList()
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


    }
}