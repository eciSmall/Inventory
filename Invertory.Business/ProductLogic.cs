using Inventory.Model;
using Invertory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Business
{
    public class ProductLogic
    {
        ProductRepository productRepository = new ProductRepository();
        public BaseResponse AddProduct(ProductModel productModel)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = productRepository.AddProduct(productModel),
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
        public BaseResponse AddOwnProduct(OwnProduct ownProduct)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = productRepository.AddOwnProduct(ownProduct),
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
