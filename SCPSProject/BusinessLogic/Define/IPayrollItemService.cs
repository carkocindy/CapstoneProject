using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogic.Define
{
    public interface IPayrollItemService
    {
        void Create(PayrollItem entity);
        void Update(PayrollItem entity);
        void Delete(PayrollItem entity);
        PayrollItem Get(Expression<Func<PayrollItem, bool>> predicated, params Expression<Func<PayrollItem, object>>[] includes);
        IQueryable<PayrollItem> GetAll(params Expression<Func<PayrollItem, object>>[] includes);
    }
}
