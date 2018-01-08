using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Business
{
    public class PartnerLogic
    {
        Repository.PartnerRepository partnerRepository = new Repository.PartnerRepository();
        public BaseResponse Add(Partner partner)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = partnerRepository.Add(partner),
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
        public BaseResponse AddPartnerRequest(PartnerRequest partnerRequest)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = partnerRepository.AddPartnerRequest(partnerRequest),
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
        public BaseResponse Login(Partner partner, out int partnerId)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = partnerRepository.Login(partner, out partnerId)
                };
            }
            catch (Exception ex)
            {
                partnerId = 0;
                return new BaseResponse()
                {
                    Status = ResponseStatus.InternalError,
                    EndUserMessage = "یک مشکل پیش آماده است"
                };
            }
        }
        public List<PartnerRequest> PartnerRquestList()
        {
            try
            {
                return partnerRepository.PartnerRquestList();
            }
            catch (Exception ex)
            {
                return new List<PartnerRequest>()
                {
                };
            }
        }
        public Partner GetPartner(int partnerId)
        {
            try
            {
                return partnerRepository.GetPartner(partnerId);
            }
            catch (Exception ex)
            {
                return new Partner()
                {
                };
            }
        }
        public List<PartnerRequest> PartnerRquestListByPartner(int partnerId)
        {
            try
            {
                return partnerRepository.PartnerRquestListByPartner(partnerId);
            }
            catch (Exception ex)
            {
                return new List<PartnerRequest>()
                {
                };
            }
        }

    }
}
