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
    }
}
