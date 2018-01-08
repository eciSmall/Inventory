using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Business
{
    public class InventoryLogic
    {
        Repository.InventoryRepository inventoryRepository;
        public InventoryLogic()
        {
            inventoryRepository = new Repository.InventoryRepository();
        }
        public BaseResponse Add(InventoryModel inventoryModel)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = inventoryRepository.Add(inventoryModel),
                    EndUserMessage = "با موفقیت اضافه شد"
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse()
                {
                    Status = ResponseStatus.InternalError,
                    EndUserMessage = "یک مشکل پیش آماده است"
                };
            }
        }
        public BaseResponse AddInventoryExpenses(InventoryExpenses inventoryExpenses)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = inventoryRepository.AddInvertoryExpenses(inventoryExpenses),
                    EndUserMessage = "با موفقیت اضافه شد"
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse()
                {
                    Status = ResponseStatus.InternalError,
                    EndUserMessage = "یک مشکل پیش آماده است"
                };
            }
        }
        public List<InventoryModel> InventoryNameList()
        {
            return inventoryRepository.InventoryNameList();
        }
        public List<InventoryModel> InventoryList()
        {
            try
            {
                return inventoryRepository.InventoryList();
            }
            catch (Exception ex)
            {
                return new List<InventoryModel>()
                {
                };
            }
        }
        public BaseResponse Delete(InventoryModel inventoryModel)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = inventoryRepository.Delete(inventoryModel),
                    EndUserMessage = "با موفقیت حذف شد"
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse()
                {
                    Status = ResponseStatus.InternalError,
                    EndUserMessage = "یک مشکل پیش آماده است"
                };
            }
        }
        public BaseResponse AddRepairUnit(RepairUnit repairUnit)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = inventoryRepository.AddRepairUnit(repairUnit),
                    EndUserMessage = "با موفقیت اضافه شد"
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse()
                {
                    Status = ResponseStatus.InternalError,
                    EndUserMessage = "یک مشکل پیش آماده است"
                };
            }
        }
        public BaseResponse DeleteRepairUnit(RepairUnit repairUnit)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = inventoryRepository.DeleteRepairUnit(repairUnit),
                    EndUserMessage = "با موفقیت حذف شد"
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse()
                {
                    Status = ResponseStatus.InternalError,
                    EndUserMessage = "یک مشکل پیش آماده است"
                };
            }
        }
        public List<RepairCheck> RepairCheckList(InventoryModel inventoryModel)
        {
            try
            {
                return inventoryRepository.RepairCheckList(inventoryModel);
            }
            catch (Exception ex)
            {
                return new List<RepairCheck>()
                {
                };
            }
        }
        public BaseResponse AddRepairCheck(RepairCheck repairCheck)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = inventoryRepository.AddRepairCheck(repairCheck),
                    EndUserMessage = "با موفقیت اضافه شد"
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse()
                {
                    Status = ResponseStatus.InternalError,
                    EndUserMessage = "یک مشکل پیش آماده است"
                };
            }
        }
    }
}
