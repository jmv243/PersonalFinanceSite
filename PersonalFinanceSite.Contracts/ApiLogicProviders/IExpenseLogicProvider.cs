using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSite.Contracts.ApiLogicProviders
{
    public interface IExpenseLogicProvider
    {
        void AddExpense(IExpense expense);
        IExpense GetExpenseByPK(Guid expensePK);
        List<IExpense> GetExpenses(Guid userFK);
        IExpense UpdateExpense(IExpense expense);
        IExpense DeleteExpense(Guid expensePK);
    }
}
