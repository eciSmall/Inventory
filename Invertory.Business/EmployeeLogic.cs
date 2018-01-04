using Inventory.Model;
using Invertory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Business
{
    public class EmployeeLogic
    {
        EmployeeRepository employeeRepository;
        public EmployeeLogic()
        {
            employeeRepository = new EmployeeRepository();
        }
        public BaseResponse Add(Employee employee)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = employeeRepository.Add(employee),
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
        public BaseResponse AddEmployeeContractKind(EmployeeContractKind employeeContractKind)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = employeeRepository.AddEmployeeContractKind(employeeContractKind),
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
        public BaseResponse AddEmployeeFault(EmployeeFault employeeFault)
        {
            try
            {
                return new BaseResponse()
                {
                    Status = employeeRepository.AddEmployeeFault(employeeFault),
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
        public List<Employee> EmployeeList()
        {
            try
            {
                return employeeRepository.EmployeeList();
            }
            catch (Exception ex)
            {
                return new List<Employee>()
                {

                };
            }
        }
    }
}
