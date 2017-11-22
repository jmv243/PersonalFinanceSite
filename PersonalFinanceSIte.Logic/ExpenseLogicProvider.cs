using System;
using System.Collections.Generic;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSIte.Logic
{
    public class ExpenseLogicProvider : IExpenseLogicProvider
    {
        public void AddExpense(IExpense expense)
        {
            throw new NotImplementedException();
        }

        public IExpense DeleteExpense(Guid expensePK)
        {
            throw new NotImplementedException();
        }

        public IExpense GetExpenseByPK(Guid expensePK)
        {
            throw new NotImplementedException();
        }

        public List<IExpense> GetExpenses(Guid userFK)
        {
            throw new NotImplementedException();
        }

        public IExpense UpdateExpense(IExpense expense)
        {
            throw new NotImplementedException();
        }
    }
}