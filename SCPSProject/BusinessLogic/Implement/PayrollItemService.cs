using BusinessLogic.Define;
using DataAccess;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Implement
{
    public class PayrollItemService : _BaseService<PayrollItem>, IPayrollItemService
    {
        public PayrollItemService(IUnitOfWork unitOfWork) : base (unitOfWork)
        {

        }
    }
}
